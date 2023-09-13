using Project_12.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12.DataAccess.InMemory.Abstract
{
    internal interface IAccountDal
    {
        public bool DepositMoney(decimal money);
        public bool WithDrawMoney(decimal money);
    }
}
