using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OxyPlotTest;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFactorial_3()
        {
            int a = 3;
            int correct_result = 6;

            Factorial factor = new Factorial();
            int actual_result = factor.Calculate_Factorial(a);

            Assert.AreEqual(correct_result, actual_result);
        }

        [TestMethod]
        public void TestFactorial_0()
        {
            int a = 0;
            int correct_result = 1;

            Factorial factor = new Factorial();
            int actual_result = factor.Calculate_Factorial(a);

            Assert.AreEqual(correct_result, actual_result);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFactorial_minus_10()
        {
            int a = -10;
            int correct_result = 1;

            Factorial factor = new Factorial();
            int actual_result = factor.Calculate_Factorial(a);

            
        }
    }
}
