using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        Accounting_DBEntities dBEntities = new Accounting_DBEntities();

        ICustomerRepository _customerRepository;

        public ICustomerRepository customerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(dBEntities);
                }
                return _customerRepository;
            }
        }

        private GenericRepository<Accounting> _genericRepository;
        public GenericRepository<Accounting> accountingRepository
        {
            get
            {
                if (_genericRepository == null)
                {
                    _genericRepository = new GenericRepository<Accounting>(dBEntities);
                }
                return _genericRepository;
            }
        }

        private GenericRepository<Login> _loginRepository;
        public GenericRepository<Login> loginRepository
        {
            get
            {
                if (_loginRepository == null)
                {
                    _loginRepository = new GenericRepository<Login>(dBEntities);
                }
                return _loginRepository;
            }

        }

        public void Save()
        {
            dBEntities.SaveChanges();
        }

        public void Dispose()
        {
            dBEntities.Dispose();
        }
    }
}
