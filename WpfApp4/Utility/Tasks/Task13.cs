using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task13
    {
        private double x;
        private double a;

        public Task13(double x, double a)
        {
            this.x = x;
            this.a = a;
        }
        public double CalculatorW()
        {
            return Math.Pow(x, 2) * Math.Sqrt(Math.Abs(a + x));
        }
        public double CalculatorZ()
        {
            double w = CalculatorW();
            return Math.Pow(Math.Cos(a), 2) + Math.Pow(w, 2);
        }
        public double CalculatorY()
        {
            double z = CalculatorZ();
            double w = CalculatorW();
            return a * Math.Pow(z, 7) + Math.Pow(Math.Sin(w), 2);
        }
        public string Result()
        {
            double z = CalculatorZ();
            double w = CalculatorW();
            double y = CalculatorY();

            return $"z = {z}\nw = {w}\ny = {y}";
        }
    }
}
