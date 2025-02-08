using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task6
    {
        private double m;
        private double x;

        public Task6(double m, double x)
        {
            this.m = m;
            this.x = x;
        }
        public double CalculateA()
        {
            return Math.Sqrt(x);
        }
        public double CalculateB()
        {
            return Math.Pow(x, 4) + Math.Pow(m, 2);
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return Math.Pow(Math.Sin(a + Math.Pow(Math.Tan(b), 3)),2);
        }
        public string Result()
        {
            double a = CalculateA();
            double b = CalculateB();
            double y = CalculateY();

            return $"a = {a}\nb = {b}\ny = {y}";
        }
    }
}
