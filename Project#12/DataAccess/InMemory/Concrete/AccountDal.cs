using Project_11.Entity;
using Project_12.DataAccess.InMemory.Abstract;
using Project_12.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12.DataAccess.InMemory.Concrete
{
    internal class AccountDal : IAccountDal
    {
        private Account _account;
        public AccountDal()
        {
            
        }
        public AccountDal(Account account) 
        {
            _account = account;
        }

        public bool DepositMoney(decimal money)
        {
            try
            {
                _account.AddMoney(money);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool WithDrawMoney(decimal money)
        {
            try
            {
                _account.RemoveMoney(money);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
