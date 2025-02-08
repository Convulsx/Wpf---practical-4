using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task21
    {
        private double n;
        private double b;

        public Task21(double n, double b)
        {
            this.n = n;
            this.b = b;
        }
        public double CalculatorX()
        {
            return Math.Pow(n, b) + Math.Pow(b, 2);
        }
        public double CalculatorA()
        {
            double x = CalculatorX();
            return Math.Sin(Math.Pow(x, 4) + Math.Pow(b, 2));
        }
        public double CalculatorY()
        {
            double a = CalculatorA();
            return Math.Log10(a) / Math.Log10(Math.Pow(b, 3));
        }
        public string Result()
        {
            double x = CalculatorX();
            double y = CalculatorY();
            double a = CalculatorA();

            return $"x = {x}\ny = {y}\na = {a}";
        }
    }
}
