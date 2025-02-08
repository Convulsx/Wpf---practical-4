using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task25
    {
        private double p;
        private double a;

        public Task25(double p, double a)
        {
            this.p = p;
            this.a = a;
        }
        public double CalculatorT()
        {
            return Math.Pow(p, 3) + Math.Pow(a, 3);
        }
        public double CalculatorX()
        {
            return Math.Exp(Math.Sqrt(p + a));
        }
        public double CalculatorY()
        {
            double x = CalculatorX();
            double t = CalculatorT();
            return Math.Pow(x, 3) / Math.Pow(t, 2);
        }
        public string Result()
        {
            double t = CalculatorT();
            double x = CalculatorX();
            double y = CalculatorY();
            return $"t = {t}\nx = {x}\ny = {y}";
        }
    }
}
