using Project_12.Business.Abstract;
using Project_12.DataAccess.InMemory.Abstract;
using Project_12.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12.Business.Concrete
{
    internal class AccountManager : IAccountService
    {
        public IAccountDal accountDal;

        public AccountManager(IAccountDal accountDal)
        {
            this.accountDal = accountDal;
        }


        public bool DepositMoney(decimal money)
        {
            return accountDal.DepositMoney(money);
        }

        public bool WithDrawMoney(decimal money)
        {
            return accountDal.WithDrawMoney(money);
        }
    }
}
