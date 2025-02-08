using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task12
    {
        private double q;
        private double b;

        public Task12(double q, double b)
        {
            this.q = q;
            this.b = b;
        }
        public double CalculatorT()
        {
            return Math.Pow(b, 3) + Math.Exp(Math.Sqrt(q));
        }
        public double CalculatorX()
        {
            double t = CalculatorT();
            return Math.Pow(t, 3) + Math.Pow(b, 2);
        }
        public double CalculatorY()
        {
            double x = CalculatorX();
            return Math.Pow(Math.Tan(Math.Abs(x)), 2);
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
