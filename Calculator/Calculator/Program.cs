using Calculator.Equation;
using System;
using ClassLibrary;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            MathObject eq = new MathObject();

            GatheringInput(eq);


        }

        public static void GatheringInput(MathObject eq)
        {
            double answer;

            Console.WriteLine("Welcome to my VHS app \n");
            Console.WriteLine("Type A - for Addition \n");
            Console.WriteLine("Type B - for Subtraction \n");
            Console.WriteLine("Type C - for Multiplication \n");
            Console.WriteLine("Type D - for Division \n");
            eq.op = Console.ReadLine().ToUpper();

            eq.newOperation = DetermineOperation(eq.op);

            Console.WriteLine("Thank you \n");
            Console.WriteLine("Please enter your first value: ");
            eq.value1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Thank you \n");
            Console.WriteLine("Please enter your second value: ");
            eq.value2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Thank you \n");

            Console.WriteLine("Ok, your equation is " + eq.value1 + eq.newOperation + eq.value2);

            answer = ClassLibrary.Addition(eq.value1, eq.value2);

            Console.WriteLine(" The answer is " + answer);

            Console.WriteLine("Hit Enter to continue");
            Console.ReadLine();
        }

        public static string DetermineOperation(string op)
        {
            if (op == null)
            {
                throw new ArgumentNullException(nameof(op));
            }

            string opValue;

            switch (op)
            {
                case "A":
                    opValue = " + ";
                    return opValue;
                case "B":
                    opValue = " - ";
                    return opValue;
                case "C":
                    opValue = " * ";
                    return opValue;
                case "D":
                    opValue = " / ";
                    return opValue;

                default:
                    throw new FormatException();
                    
            }
        }
    }
}
