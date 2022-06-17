using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyNUnit
{
    public class GradeCalculator
    {
        public static string GetGrade(int percentage)
        {
            if (percentage > 90 & percentage <= 100)
                return "bdb";
            else if (percentage > 75 & percentage <= 90)
                return "db";
            else if (percentage > 50 & percentage <= 75)
                return "dst";
            else if (percentage > 40 & percentage <= 50)
                return "dop";
            else if (percentage >= 0 & percentage < 90)
                return "ndst";
            else
                return "invalid";
        }
    }
}
