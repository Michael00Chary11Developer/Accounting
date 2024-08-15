using Accounting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Accounting.ViewModel.CustomerModel;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        Accounting_DBEntities db;
        public CustomerRepository(Accounting_DBEntities context)
        {
            db = context;
        }

        public IEnumerable<Customers> GetCustomersByFilter(string parameter)
        {
            return db.Customers.Where(cu => cu.FullName.Contains(parameter)
                                    || cu.MobilePhoneNumber.Contains(parameter)
                                    || cu.Address.Contains(parameter)
                                    || cu.Email.Contains(parameter)).ToList();
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customers GetCustomerByID(int customerId)
        {
            //var customer = db.Customers.Find(customerId);
            /*Customers customer = db.Customers.Find(customerId);
            return customer;*/
            return db.Customers.Find(customerId);
        }

        public bool DeleteCustomerById(int customerId)
        {
            try
            {
                Customers customerDeleteById = GetCustomerByID(customerId);
                DeleteCustomers(customerDeleteById);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomers(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertCustomers(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool UpdateCustomers(Customers customer)
        {
            Customers local = db.Set<Customers>()
                         .Local
                         .FirstOrDefault(f => f.CustomerID == customer.CustomerID);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(customer).State = EntityState.Modified;
            return true;
        }

        public bool UpdateCustomersByID(int customerId)
        {
            try
            {
                var customerFindById = GetCustomerByID(customerId);
                UpdateCustomers(customerFindById);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<string> GetCustomerByName(string customerNameFilter = null)
        {
            if (customerNameFilter == null)
            {
                return db.Customers.Select(c => c.FullName).ToList();
            }
            return db.Customers.Where(c => c.FullName.Contains(customerNameFilter)).Select(c => c.FullName).ToList();
        }

        public List<ListCustomerViewModel> GetCustomerByFullName(string customerNameFilter = null)
        {
            if (customerNameFilter == null)
            {
                return db.Customers.Select(c => new ListCustomerViewModel()
                {
                    CustomerID = c.CustomerID,
                    FullName = c.FullName
                }).ToList();
            }
            return db.Customers.Where(c => c.FullName.Contains(customerNameFilter)).Select(c => new ListCustomerViewModel()
            {
                CustomerID = c.CustomerID,
                FullName = c.FullName
            }).ToList();
        }

        public int GetCustomerIdByFullName(string name)
        {
            return db.Customers.First(c => c.FullName == name).CustomerID;
        }

        public string GetCustomerNameById(int id)
        {
            return db.Customers.Find(id).FullName;
        }
    }
}
