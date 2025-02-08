using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task17
    {
        private double x;
        private double t;

        public Task17(double x, double c)
        {
            this.x = x;
            this.t = c;
        }
        public double CalculatorB()
        {
            return Math.Pow(Math.Log(Math.Abs(x)), 2);
        }
        public double CalculatorA()
        {
            double b = CalculatorB();
            return t * x + Math.Abs(Math.Sqrt(b));
        }
        public double CalculatorY()
        {
            double b = CalculatorB();
            double a = CalculatorA();
            return Math.Pow(Math.Cos(b), 2) + b * Math.Pow(Math.Cos(Math.Pow(a, 2)),4);
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
