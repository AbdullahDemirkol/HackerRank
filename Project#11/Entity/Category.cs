using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_11.Entity
{
    internal class Category
    {
        private int voteCount = 0;
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public void Vote()
        {
            voteCount += 1;
        }
        public int GetVoteCount() 
        {  
            return voteCount; 
        }
    }
}
