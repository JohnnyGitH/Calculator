using System;

namespace ClassLibrary
{
    public class Calculator
    {

        // Math based functions/methods should go here eventually

        public double Addition(double value1, double value2)
        {
            double answer;
            double input1 = value1;
            double input2 = value2;

            if (input1 == null || input2 == null)
            {
                throw new FormatException();
            }

            answer = input1 + input2;


            return answer;
        }

    }
}
