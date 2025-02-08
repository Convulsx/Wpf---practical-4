using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task4
    {
        private double x;
        private double t;

        public Task4(double x, double t)
        {
            this.x = x;
            this.t = t;
        }
        public double CalculateA()
        {
            return Math.Log10(x);
        }
        public double CalculateB()
        {
            return Math.Sqrt(Math.Pow(x,2) + Math.Pow(t, 2));
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return 5 * Math.Sqrt(Math.Abs(a - b * x));
        }
        public string Result()
        {
            double a = CalculateA();
            double b = CalculateB();
            double y = CalculateY();
            return $" a = {a}\nb = {b}\ny = {y}";
        }
        
    }
}
