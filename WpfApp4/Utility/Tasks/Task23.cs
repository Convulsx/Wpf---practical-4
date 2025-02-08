using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task23
    {
        private double b;
        private double x;

        public Task23(double b, double x)
        {
            this.b = b;
            this.x = x;
        }
        public double CalculatorT()
        {
            return x * Math.Pow(b, 2) + Math.Sqrt(x);
        }
        public double CalculatorA()
        {
            double t = CalculatorT();
            return Math.Log10(Math.Abs(t * x + Math.Pow(b , 2)));
        }
        public double CalculatorY()
        {
            double a = CalculatorA();
            double t = CalculatorT();
            return Math.Log(a + b) + Math.Pow(a, 2) / a + t;
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
