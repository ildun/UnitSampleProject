using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitSample
{
    public class QuadEqua
    {
        public class NotAQuadraticEquationException : Exception
        {
            public NotAQuadraticEquationException():base("It is not a Quadratic equation")
            {
            }
        }
        private double a;
        private double b;
        private double c;
        private Complex root1;
        private Complex root2;

        public QuadEqua(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            Solve();
        }

        static public double CalculateDiscriminant(double a, double b, double c)
        {
            return b * b - 4.0 * a * c;
        }


        public Complex Root1 { get => root1; }
        public Complex Root2 { get => root2; }
        public double A { get => a; set { a = value; Solve(); } }
        public double B { get => b; set { b = value; Solve(); } }
        public double C { get => c; set { c = value; Solve(); } }

        public void Solve()
        {
            if (a == 0) throw new NotAQuadraticEquationException();
            Complex sqrtD = Complex.Sqrt(CalculateDiscriminant(a, b, c));
            root1 = (-b + sqrtD) / (2 * a);
            root2 = (-b - sqrtD) / (2 * a);
        }
    }
}
