using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12.Services
{
    internal class LoggerService
    {
        public void Logger(string message) 
        {
            File.AppendAllText("EOD_"+DateTime.Now.ToString("dd-MM-yyyy") +".txt", message);
            File.AppendAllText("EOD_" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt","\n");
        }
    }
}
