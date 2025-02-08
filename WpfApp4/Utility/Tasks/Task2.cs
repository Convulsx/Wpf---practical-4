using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task2
    {
        private double _x;


        public Task2(double x)
        {
            _x = x;

        }
        public double CalculateA()
        {
            return Math.Log10(Math.Abs(_x));
        }
        public double CalculateB()
        {
            double a = CalculateA();
            return Math.Exp(2 * _x) + a * _x;
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return Math.Pow(_x * a, 3) + Math.Pow(b, 2);
        }
        public string Result()
        {
            double a = CalculateA();
            double b = CalculateB();
            double y = CalculateY();

            return $"a = {a}\nb = {b}\n y = {y}";
        }
    }
}
