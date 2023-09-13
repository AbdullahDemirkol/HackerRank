using Project_12.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12.Business.Abstract
{
    internal interface IAccountService
    {
        public bool WithDrawMoney(decimal money);
        public bool DepositMoney(decimal money);
    }
}
