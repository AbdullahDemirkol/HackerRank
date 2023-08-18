using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge20
{
    internal class Result
    {
        public static string TimeConversion(string s)
        {
            var dateTimeNow= Convert.ToDateTime(s);
            var dateTimeHour = (dateTimeNow.Hour > 10) ? dateTimeNow.Hour.ToString() : "0" +dateTimeNow.Hour.ToString();
            var dateTimeMinute = (dateTimeNow.Minute > 10) ? dateTimeNow.Minute.ToString() : "0" + dateTimeNow.Minute.ToString();
            var dateTimeSecond = (dateTimeNow.Second > 10) ? dateTimeNow.Second.ToString() : "0" + dateTimeNow.Second.ToString();

            var result = (dateTimeHour + ":" + dateTimeMinute + ":" + dateTimeSecond).ToString();
            return result;
        }
    }
}
