using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task1
    {
        private double _x;
        private double _b;

        public Task1(double x, double b)
        {
            _x = x;
            _b = b;
        }
        public double CalculateA()
        {
            return Math.Log10(_x);
        }

        public double CalculateC()
        {
            double a = CalculateA();
            return Math.Pow(a, 2) + Math.Sqrt(_b * _x);
        }

        public double CalculateY()
        {
            double c = CalculateC();
            return Math.Exp(2 * _x) + 9.7 * c;
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
