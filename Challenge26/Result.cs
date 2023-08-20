using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge26
{
    internal class Result
    {
        public static List<int> GradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] >= 37)
                {
                    var mode = grades[i] % 5;
                    if (mode >= 3)
                    {
                        grades[i] += (5 - mode);
                    }
                }
            }
            return grades;
        }
    }
}
