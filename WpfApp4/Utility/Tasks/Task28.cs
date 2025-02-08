using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task28
    {
        private double b;
        private double k;

        public Task28(double b, double k)
        {
            this.b = b;
            this.k = k;
        }
        public double CalculatorT()
        {
            return Math.Pow(k, 2) + Math.Sqrt(b);
        }
        public double CalculatorA()
        {
            double t = CalculatorT();
            return b + Math.Pow(t, 2) * Math.Exp(t);
        }
        public double CalculatorY()
        {
            double a = CalculatorA();
            return Math.Pow(Math.Cos(Math.Pow(a, 3) + b), 4);
        }
        public string Result()
        {
            double t = CalculatorT();
            double a = CalculatorA();
            double y = CalculatorY();
            return $"t = {t}\na = {a}\ny = {y}";
        }
    }
}
