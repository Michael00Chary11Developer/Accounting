using Accounting.ViewModel.CustomerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<Customers> GetAllCustomers();
        IEnumerable<Customers> GetCustomersByFilter(string parameter);
        List<string> GetCustomerByName(string customerNameFilter = null);
        List<ListCustomerViewModel> GetCustomerByFullName(string customerNameFilter = null);
        Customers GetCustomerByID(int customerId);
        bool InsertCustomers(Customers customer);
        bool UpdateCustomers(Customers customer);
        bool UpdateCustomersByID(int customerId);
        bool DeleteCustomers(Customers customer);
        bool DeleteCustomerById(int customerId);
        int GetCustomerIdByFullName(string name);
        string GetCustomerNameById(int id);
    }
}
