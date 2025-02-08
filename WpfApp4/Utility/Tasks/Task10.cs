using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task10
    {
        private double x;
        private double b;

        public Task10(double x, double b)
        {
            this.x = x;
            this.b = b;
        }
        public double CalculateA()
        {
            return Math.Pow(b, 3) + Math.Log(Math.Abs(b));
        }
        public double CalculateC()
        {
            double a = CalculateA();
            return Math.Pow(a, 2) + Math.Sqrt(b);
        }
        public double CalculateY()
        {
            double c = CalculateC();
            return Math.Exp(x) + Math.Pow(5.8, c);
        }
        public string Result()
        {
            double a = CalculateA();
            double c = CalculateC();
            double y = CalculateY();

            return $"a = {a}\nc = {c}\ny = {y}";
        }
    }
}
