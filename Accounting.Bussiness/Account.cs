using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Context;
using Accounting.ViewModel.AccountViewModel;

namespace Accounting.Bussiness
{
    public class Account
    {
        public static AccountViewModel AccountModel()
        {
            AccountViewModel rp = new AccountViewModel();
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime EndDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);
                var recieve = unitOfWork.accountingRepository.Get(a => a.TypeID == 1 && a.DateTitle >= startDate && a.DateTitle <= EndDate).Select(a => a.Amount).ToList();
                var pay = unitOfWork.accountingRepository.Get(a => a.TypeID == 2 && a.DateTitle >= startDate && a.DateTitle <= EndDate).Select(a => a.Amount).ToList();

                rp.recieve = recieve.Sum();
                rp.pay = pay.Sum();
                rp.AccountBalance = (recieve.Sum()) - (pay.Sum());
            }
            return rp;
        }


    }
}
