using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace WpfApp4.Utility.Tasks
{
    internal class Task18
    {
        private double x;
        private double b;

        public Task18(double x, double b)
        {
            this.x = x;
            this.b = b;
        }
        public double CalculatorA()
        {
            return Math.Sqrt(Math.Abs(x)) + Math.Exp(Math.Sqrt(b));
        }
        public double CalculatorC()
        {
            double a = CalculatorA();
            return Math.Log10(a) + Math.Pow(b, 2);
        }
        public double CalculatorY()
        {
            double a = CalculatorA();
            double c = CalculatorC();
            return Math.Pow(a, 3) / Math.Cos(c);
        }
        public string Result()
        {
            double a = CalculatorA();
            double c = CalculatorC();
            double y = CalculatorY();

            return $"a = {a}\nc = {c}\ny = {y}";
        }
    }
}
