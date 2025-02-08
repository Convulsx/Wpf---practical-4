using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task27
    {
        private double t;
        private double a;

        public Task27(double t, double a)
        {
            this.t = t;
            this.a = a;
        }
        public double CalculatorC()
        {
            return Math.Pow(t, 2) + Math.Sqrt(a);
        }
        public double CalculatorX()
        {
            double c = CalculatorC();
            return Math.Log10(Math.Abs(c * t)) + Math.Pow(a, 2);
        }
        public double CalculatorY()
        {
            double x = CalculatorX();
            return Math.Tan(x * 4) + Math.Sin(Math.Pow(x, 2));
        }
        public string Result()
        {
            double c = CalculatorC();
            double x = CalculatorX();
            double y = CalculatorY();

            return $"c = {c}\nx = {x}\ny = {y}";
        }
    }
}
