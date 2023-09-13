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
    internal class CreditManager : ICreditService
    {
        public ICreditDal creditDal;

        public CreditManager()
        {
        }

        public CreditManager(ICreditDal creditDal)
        {
            this.creditDal = creditDal;
        }

        public bool AddCredit(Credit credit)
        {
            return creditDal.AddCredit(credit);
        }

        public List<Credit> GetCredits()
        {
            return creditDal.GetCredits();
        }

        public string PayCredit(int choice, double payMoney)
        {
            return creditDal.PayCredit(choice, payMoney);
        }
    }
}
