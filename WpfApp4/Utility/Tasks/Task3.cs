using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task3
    {
        private double _x;
        private double _p;

        public Task3(double x, double p)
        {
            _x = x;
            _p = p;
        }
        public double CalculateA()
        {
            return Math.Exp(Math.Sqrt(Math.Abs(_x)));
        }
        public double CalculateB()
        {
            return (Math.Sin(Math.Pow(_p, 2)) + Math.Pow(_x, 3));
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return Math.Pow(a, 3) / Math.Pow(b, 2);
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
