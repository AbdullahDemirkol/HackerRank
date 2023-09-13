using Project_12.DataAccess.InMemory.Abstract;
using Project_12.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Project_12.DataAccess.InMemory.Concrete
{
    internal class CreditDal : ICreditDal
    {
        private readonly List<Credit> _credits;

        public CreditDal()
        {
            
        }
        public CreditDal(List<Credit> credits)
        {
            _credits = credits;
        }

        public bool AddCredit(Credit credit)
        {
            try
            {
                _credits.Add(credit);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Credit> GetCredits()
        {
            return _credits;
        }

        public string PayCredit(int choice, double payMoney)
        {
            Credit credit= _credits.Find(p=>p.Id==choice);
            if (credit.RemainingTotalCreditMoney>payMoney)
            {
                credit.RemainingTotalCreditMoney -= payMoney;
                if (credit.RemainingCreditMoneyThisMonth<payMoney)
                {
                    credit.RemainingCreditMoneyThisMonth += (credit.TotalCreditMoney / credit.CreditAllCount);
                }
                credit.RemainingCreditMoneyThisMonth -= payMoney;
                if (credit.RemainingCreditMoneyThisMonth<=0)
                {
                    if (credit.RemainingTotalCreditMoney> (credit.TotalCreditMoney / credit.CreditAllCount))
                    {
                        credit.RemainingCreditMoneyThisMonth = (credit.TotalCreditMoney / credit.CreditAllCount);
                    }
                    else
                    {
                        credit.RemainingCreditMoneyThisMonth = credit.RemainingTotalCreditMoney;
                    }
                }
                credit.CreditCountRemaining = (int)Math.Ceiling(credit.RemainingTotalCreditMoney / (credit.TotalCreditMoney / credit.CreditAllCount));
                return "Ödeme Başarılı Bir Şekilde Gerçekleşti.";
            }
            else
            {
                _credits.Remove(credit);
                var remainingMoney=payMoney-credit.RemainingTotalCreditMoney;
                if (remainingMoney==0)
                {
                    return "Kredinin Tamamı Ödenildi.";
                }
                else
                {
                    return $"Kredi Yatırıldıktan Sonra {remainingMoney} Miktarında Para Kaldı.";
                }
            }
        }
    }
}
