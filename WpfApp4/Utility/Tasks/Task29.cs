using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Utility.Tasks
{
    internal class Task29
    {
        private double a;
        private double b;

        public Task29(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double CalculatorX()
        {
            return Math.Exp(2 * a) + Math.Sqrt(b);
        }
        public double CalculatorP()
        {
            double x = CalculatorX();
            return x * (a + Math.Pow(b, 3));
        } 
        public double CalculatorY()
        {
            double x = CalculatorX();
            double p = CalculatorP();
            return Math.Pow(Math.Log(Math.Abs(p)), 3) + x;
        }
        public string Result()
        {
            double x = CalculatorX();
            double p = CalculatorP();
            double y = CalculatorY();

            return $"x = {x}\np = {p}\ny = {y}";
        }
    }
}
