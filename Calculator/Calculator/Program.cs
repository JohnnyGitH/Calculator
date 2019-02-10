using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            GatheringInput();



        }

        public static void GatheringInput()
        {
            string op;
            string newOp;
            double value1;
            double value2;

            Console.WriteLine("Welcome to my VHS app \n");
            Console.WriteLine("Type A - for Addition \n");
            Console.WriteLine("Type B - for Subtraction \n");
            Console.WriteLine("Type C - for Multiplication \n");
            Console.WriteLine("Type D - for Division \n");
            op = Console.ReadLine().ToUpper();

            newOp = DetermineOperation(op);

            Console.WriteLine("Thank you \n");
            Console.WriteLine("Please enter your first value: ");
            value1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Thank you \n");
            Console.WriteLine("Please enter your second value: ");
            value2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Thank you \n");

            Console.WriteLine("Ok, your equation is " + value1 + newOp + value2);

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
