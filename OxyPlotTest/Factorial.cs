using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxyPlotTest
{
   public class Factorial
    {
        int Calculate_Factorial(int a)
        {
            int result=1;
            for (int i = 1; i < a; i++)
                result *= a;
            return result;
        }
    }
}
