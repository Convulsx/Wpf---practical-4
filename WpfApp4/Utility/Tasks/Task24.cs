using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task24
    {
        private double t;
        private double b;

        public Task24(double t, double b)
        {
            this.t = t;
            this.b = b;
        }
        public double CalculatorA()
        {
            return Math.Pow(t, 2) * b;
        }
        public double CalculatorX()
        {
            double a = CalculatorA();
            return Math.Pow(a, 3) + Math.Sqrt(t + b);
        }
        public double CalculatorY()
        {
            double x = CalculatorX();
            return Math.Cos(Math.Pow(x, 5)) - b * Math.Pow(Math.Sin(x), 2);
        }
        public string Result()
        {
            double a = CalculatorA();
            double x = CalculatorX();
            double y = CalculatorY();

            return $"a = {a}\nx = {x}\ny = {y}";
        }
    }
}
