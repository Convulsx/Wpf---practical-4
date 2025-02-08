using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task20
    {
        private double x;
        private double p;

        public Task20(double x, double p)
        {
            this.x = x;
            this.p = p;
        }
        public double CalculatorA()
        {
            return Math.Log10(Math.Abs(x));
        }
        public double CalculatorB()
        {
            return Math.Pow(x, 4) + Math.Log10(Math.Pow(p, 3));
        }
        public double CalculatorY()
        {
            double a = CalculatorA();
            double b = CalculatorB();
            return Math.Pow(Math.Sin(a * x), 3) + Math.Sqrt(b) * Math.Cos(Math.Pow(x, 2));
        }
        public string Result()
        {
            double a = CalculatorA();
            double b = CalculatorB();
            double y = CalculatorY();

            return $"a = {a}\nb = {b}\ny = {y}";
        }
    }
}
