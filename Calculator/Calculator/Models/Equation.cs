using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Equation
{
    public class Equation
    {
        public string op { get; set; }
        public string newOperation { get; set; }
        public double value1 { get; set; }
        public double value2 { get; set; }


        public double GetValue1(Equation eq)
        {
            if (eq == null)
            {
                throw new ArgumentNullException(nameof(eq));
            }

            double value = eq.value1;

            return value;
        }

        public double GetValue2(Equation eq)
        {
            if (eq == null)
            {
                throw new ArgumentNullException(nameof(eq));
            }

            double value = eq.value2;

            return value;
        }

        public string GetOperation(Equation eq)
        {
            if (eq == null)
            {
                throw new ArgumentNullException(nameof(eq));
            }

            string value = eq.op;

            return value;
        }

        public string GetNewOperation(Equation eq)
        {
            if (eq == null)
            {
                throw new ArgumentNullException(nameof(eq));
            }

            string value = eq.newOperation;

            return value;
        }
    }
}
