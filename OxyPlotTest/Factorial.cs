using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxyPlotTest
{
   public class Factorial
    {
        public int Calculate_Factorial(int a)
        {
            if (a < 0)
                throw new ArgumentException("error of input");            int result=1;
            for (int i = 1; i <=a; i++)
                result *= i;
            
            return result;
        }
    }
}
