using Project_12.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12.DataAccess.InMemory.Abstract
{
    internal interface ICreditDal
    {
        bool AddCredit(Credit credit);
        List<Credit> GetCredits();
        string PayCredit(int choice, double payMoney);
    }
}
