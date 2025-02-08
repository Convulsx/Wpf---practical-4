using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task22
    {
        private double m;
        private double p;

        public Task22(double m, double p)
        {
            this.m = m;
            this.p = p;
        }
        public double CalculatorT()
        {
            return Math.Sin(Math.Pow(m, 3));
        }
        public double CalculatorX()
        {
            double t = CalculatorT();
            return Math.Pow(p, 2) + t;
        } 
        public double CalculatorY()
        {
            double t = CalculatorT();
            double x = CalculatorX();
            return Math.Pow(Math.Log10(Math.Abs(x + t)),4);
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
