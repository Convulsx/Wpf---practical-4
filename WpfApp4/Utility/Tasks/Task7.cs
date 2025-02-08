using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task7
    {
        private double k;
        private double x;

        public Task7(double k, double x)
        {
            this.k = k;
            this.x = x;
        }
        public double CalculateC()
        {
            return Math.Sqrt(Math.Abs(x));
        }
        public double CalculateA()
        {
            double c = CalculateC();
            return Math.Pow(c, 4) + Math.Pow(k, 3);
        }
        public double CalculateY()
        {
            double a = CalculateA();
            return Math.Pow(Math.Log10(a), 3) + Math.Pow(Math.Cos(x), 5);
        }
        public string Result()
        {
            double a = CalculateA();
            double y = CalculateY();
            double c = CalculateC();

            return $"a = {a}\ny = {y}\nc = {c}";
        }
    }
}
