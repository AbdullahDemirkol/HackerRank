using Project_11.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12.Entity
{
    internal class Account
    {
        public Account()
        {
            Id = id;
            Credits = new List<Credit>();
            id++;
        }
        private decimal money=0;
        private int id = 1;

        public int Id { get; set; }
        public List<Credit> Credits { get; set; }


        public bool CreateCredit(Credit credit)
        {
            try
            {
                Credits.Add(credit);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddMoney(decimal money)
        {
            this.money += money;
            return true;
        }
        public bool RemoveMoney(decimal money)
        {
            this.money -= money;
            return true;
        }
        public decimal GetMoney() 
        { 
            return money; 
        }
    }
}
