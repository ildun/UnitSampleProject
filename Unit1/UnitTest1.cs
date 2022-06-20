using NUnit.Framework;
using UnitSample;
using System.Numerics;
using System;

namespace Unit1
{
    
    public class Tests
    {
        private const double EPS = 1e-4;
        [Test]
        [TestCase(8.0, 2.0, 1.0, -28.0)]
        [TestCase(1.0, 1.0, 1.0, -3.0)]
        public void Test_Discriminant(double a, double b, double c, double result)
        {
            double x = QuadEqua.CalculateDiscriminant(a, b, c);
            Assert.That(Math.Abs(result-x)<EPS);
            
        }
        [Test]
        [TestCase(0.0, 32.0, 91.0)]
        [TestCase(0.0, 12.0, 11.0)]
        public void Test_Ais0(double a, double b, double c)
        {
            Assert.Throws<QuadEqua.NotAQuadraticEquationException>(delegate { new QuadEqua(a, b, c); }); 
        }

        [Test]
        [TestCase(4, -16.0, 10.0, 3.2247, 0.77526 )]
        [TestCase(1, 2, -3, 1, -3)]
        [TestCase(16, -8, 1, 0.25, 0.25)]
        [TestCase(2.22, 4.32, 0, 0, -1.94594)]
        public void Test_RealSolutions(double a, double b, double c, double realResult1, double realResult2)
        {
            QuadEqua qe = new QuadEqua(a, b, c);
            Assert.That(Math.Abs(qe.Root1.Real - realResult1) < EPS);
            Assert.That(Math.Abs(qe.Root2.Real - realResult2) < EPS);
        }

        [Test]
        [TestCase(-3.34, -10.88, -43.3, -1.62874, -3.21111, -1.62874, 3.21111)]
        [TestCase(-203.34, 4.32, -6.9, 0.010622, -0.18390, 0.010622, 0.18390)]

        public void Test_ComplexSolutions(double a, double b, double c, double realResult1, double imResult1, double realResult2, double imResult2)
        {
            QuadEqua qe = new QuadEqua(a, b, c);
            Assert.That(Math.Abs(qe.Root1.Real - realResult1) < EPS);
            Assert.That(Math.Abs(qe.Root1.Imaginary - imResult1) < EPS);
            Assert.That(Math.Abs(qe.Root2.Real - realResult2) < EPS);
            Assert.That(Math.Abs(qe.Root2.Imaginary - imResult2) < EPS);
        }

    }
}