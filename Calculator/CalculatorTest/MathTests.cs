using System;
using Calculator.Equation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class MathTests
    {

        /// <summary>
        /// Testing the GetValueTest() function, 
        /// for a sample of unit testing
        /// </summary>
        [TestMethod]
        public void GetValue1Test()
        {

            var input = new MathObject();
            {
                input.newOperation = " + ";
                input.op = "A";
                input.value1 = 1;
                input.value2 = 5;
 
            };

            MathObject sut = new MathObject();

            var actual = sut.GetValue1(input);
            var expected = input.value1;

            Assert.AreEqual(expected, actual);
        }
    }
}
