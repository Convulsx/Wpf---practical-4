using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task11
    {
        private double x;
        private double b;

        public Task11(double x, double b)
        {
            this.x = x;
            this.b = b;
        }
        public double CalculatorC()
        {
            return Math.Log10(Math.Abs(x));
        }
        public double CalculatorA()
        {
            return Math.Pow((b + x), 3);
        }
        public double CalculatorY()
        {
            double c = CalculatorC();
            double a = CalculatorA();
            return Math.Pow(c, 2) + Math.Sqrt(Math.Abs(a));
        } 
        public string Result()
        {
            double c = CalculatorC();
            double a = CalculatorA();
            double y = CalculatorY();

            return $"c = {c}\na = {a}\ny = {y}";
        }
    }
}
