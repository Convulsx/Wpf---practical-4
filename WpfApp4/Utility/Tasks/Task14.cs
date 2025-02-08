using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task14
    {
        private double b;
        private double k;

        public Task14(double b, double k)
        {
            this.b = b;
            this.k = k;
        }
        public double CalculatorT()
        {
            return Math.Pow(b, 2) + Math.Pow(k, 2);
        }
        public double CalculatorA()
        {
            double t = CalculatorT();
            return Math.Sqrt(b + t);
        }
        public double CalculatorY()
        {
            double a = CalculatorA();
            return Math.Pow(Math.Sin(Math.Pow(a, 2) + Math.Pow(b, 2)), 4);
        }
        public string Result()
        {
            double a = CalculatorA();
            double t = CalculatorT();
            double y = CalculatorY();

            return $"a = {a}\nt = {t}\ny = {y}";
        }
    }
}
