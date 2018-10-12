using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class Calc : InterfaceCalc
    {
        private double a = 0;
        
        public void Put_A(double a)
        {
            this.a = a;
        }

        public void Clear_A()
        {
            a = 0;
        }

        public double Multiplication(double b)
        {
            return a * b;
        }

        public double Division(double b)
        {
            if (b == 0)
                return 0;

            return a / b;

        }

        public double Sum(double b)
        {
            return a + b;
        }

        public double Subtraction(double b)
        {
            return a - b;
        }

       
        public double DegreeY(double b)
        {
            return Math.Pow(a, b);
        }

        public double Sqrt()
        {
            if (a < 0)
                return a = 0;
            return Math.Sqrt(a);
        }

        public double Square()
        {
            return Math.Pow(a, 2.0);
        }

        public double Sin()
        {
            return Math.Sin(a);
        }
        public double Cos()
        {
            return Math.Cos(a);
        }
        public double Tag()
        {
            return Math.Tan(a);
        }

    }
}
