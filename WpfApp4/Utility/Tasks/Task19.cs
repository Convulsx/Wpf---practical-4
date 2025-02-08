using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task19
    {
        private double x;
        private double a;

        public Task19(double x, double a)
        {
            this.x = x;
            this.a = a;
        }
        public double CalculatorT()
        {
            return Math.Pow(x, 2) + Math.Pow(a, 2);
        }
        public double CalculatorP()
        {
            return Math.Pow(x, 2) - Math.Sqrt(Math.Abs(x));
        }
        public double CalculatorY()
        {
            double t = CalculatorT();
            double p = CalculatorP();
            return x * Math.Pow(p, 2) + Math.Pow(t, 5);
        }
        public string Result()
        {
            double t = CalculatorT();
            double p = CalculatorP();
            double y = CalculatorY();

            return $"t = {t}\np = {p}\ny = {y}";
        }
    }
}
