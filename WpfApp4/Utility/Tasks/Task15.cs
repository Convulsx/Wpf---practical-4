using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task15
    {
        private double a;
        private double p;

        public Task15(double a, double p)
        {
            this.a = a;
            this.p = p;
        }
        public double CalculatorB()
        {
            return Math.Abs(a) + Math.Sqrt(a + Math.Pow(p, 2));
        }
        public double CalculatorX()
        {
            double b = CalculatorB();
            return Math.Exp(b);
        }
        public double CalculatorY()
        {
            double x = CalculatorX();
            return Math.Pow(Math.Cos(x), 3) + Math.Abs(a);
        }
        public string Result()
        {
            double b = CalculatorB();
            double x = CalculatorX();
            double y = CalculatorY();

            return $"b = {b}\nx = {x}\ny = {y}";
        }
    }
}
