using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task30
    {
        private double t;
        private double b;

        public Task30(double a, double b)
        {
            this.t = a;
            this.b = b;
        }
        public double CalculatorA()
        {
            return t + Math.Pow(b, 3);
        }
        public double CalculatorX()
        {
            double a = CalculatorA();
            return Math.Pow(t, 2) * Math.Sqrt(Math.Abs(a + b));
        }
        public double CalculatorY()
        {
            double x = CalculatorX();
            double a = CalculatorA();
            return Math.Pow(Math.Log10(Math.Abs(x + Math.Pow(a, 2))), 3);
        }
        public string Result()
        {
            double x = CalculatorX();
            double a = CalculatorA();
            double y = CalculatorY();

            return $"x = {x}\na = {a}\ny = {y}";
        }
    }
}


