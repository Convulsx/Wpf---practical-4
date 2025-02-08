using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task5
    {
        private double p;
        private double t;

        public Task5(double p, double t)
        {
            this.p = p;
            this.t = t;
        }
        public double ResultK()
        {
            return Math.Sqrt(p * t);
        }
        public double ResultX()
        {
            double k = ResultK();
            return p * Math.Pow(t, 2) + Math.Sqrt(k);
        }
        public double ResultY()
        {
            double k = ResultK();
            double x = ResultX();
            return Math.Pow(Math.Tan(Math.Pow(x, 2)), 3) + k * t;
        }
        public string Result()
        {
            double x = ResultX();
            double y = ResultY();
            double k = ResultX();

            return $" x = {x}\ny = {y}\nk = {k}";
        }
    }
}
