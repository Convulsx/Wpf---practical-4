using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task16
    {
        private double x;
        private double c;

        public Task16(double x, double c)
        {
            this.x = x;
            this.c = c;
        }
        public double CalculatorB()
        {
            return x + Math.Pow(c, 2);
        }
        public double CalculatorA()
        {
            double b = CalculatorB();
            return Math.Pow(Math.Sqrt(Math.Abs(b + c)),3);
        }
        public double CalculatorY()
        {
            double b = CalculatorB();
            double a = CalculatorA();
            return Math.Pow(Math.Cos(b), 2) + b * Math.Pow(Math.Cos(Math.Pow(a, 2)), 4);
        }
        public string Result()
        {
            double b = CalculatorB();
            double a = CalculatorA();
            double y = CalculatorY();

            return $"b = {b}\na = {a}\ny = {y}";
        }
    }
}
