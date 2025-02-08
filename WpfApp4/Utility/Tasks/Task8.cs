using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task8
    {
        private double b;
        private double c;

        public Task8(double b, double c)
        {
            this.b = b;
            this.c = c;
        }
        public double CalculateA()
        {
            return Math.Sin(b);
        }
        public double CalculateX()
        {
            double a = CalculateA();
            return a + Math.Pow((b + c),2);
        }
        public double CalculateY()
        {
            double x = CalculateX();
            return 7 * Math.Exp(Math.Sqrt(x)) + Math.Pow(Math.Cos(x), 4);
        }
        public string Result()
        {
            double x = CalculateX();
            double a = CalculateA();
            double y = CalculateY();

            return $"x = {x}\na = {a}\ny = {y}";
        }
    }
}
