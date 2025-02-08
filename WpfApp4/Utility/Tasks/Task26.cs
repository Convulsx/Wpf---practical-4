using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task26
    {
        private double b;
        private double t;

        public Task26(double b, double t)
        {
            this.b = b;
            this.t = t;
        }
        public double CalculatorA()
        {
            return Math.Sqrt(b + Math.Pow(t, 2));
        }
        public double CalculatorX()
        {
            double a = CalculatorA();
            return Math.Pow(Math.Cos(b), 2) + Math.Pow(Math.Sin(a), 2);
        }
        public double CalculatorY()
        {          
            double x = CalculatorX();
            return Math.Pow(x, 2) + Math.Pow(Math.Sqrt(Math.Abs(x)),3);
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
