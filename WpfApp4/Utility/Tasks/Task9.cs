using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task9
    {
        private double k;
        private double m;

        public Task9(double k, double m)
        {
            this.k = k;
            this.m = m;
        }
        public double CalculateX()
        {
            return Math.Exp(m * k);
        }
        public double CalculateC()
        {
            return Math.Pow(Math.Cos(m), 2) + Math.Pow(k, 2);
        }
        public double CalculateY()
        {
            double x = CalculateX();
            double c = CalculateC();

            return Math.Pow(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(c, 2)),3);
        }
        public string Result()
        {
            double x = CalculateX();
            double c = CalculateC();
            double y = CalculateY();

            return $"x = {x}\nc = {c}\ny = {y}";
        }
    }
}
