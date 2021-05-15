using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseUtils
{
    public  class MathUtils
    {
        public static int CalculateSum(List<int> values)
        {
            int sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            return sum;
        }
        public static double CalculateSum(List<double> values)
        {
            double sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            return sum;
        }
    }
}
