using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(7.2, 3.8, 1, 0)]

        public void TestForFunctionValues(double a, double b, double x, double exp)
        {
            var res = Program.MyFunction(a, b, x);
            Assert.Equal(res, exp);
        }

        [Theory]
        [InlineData(0, 0, 0, 0)]

        public void TestFunctionZeroVal(double a, double b, double x, double exp)
        {
            var res = Program.MyFunction(a, b, x);
            Assert.Equal(exp, res, 3);
        }

        [Theory]
        [InlineData(7.2, 4.2, 1.81, 5.31, 0.7)]

        public void TestTaskA_Elements(double a, double b, double xn, double xk, double dx)
        {
            var res = Program.TaskA(a, b, xn, xk, dx);
            int counter = 0;
            foreach (double elem in res)
            {
                    counter++;
            }

            double massElemExpected = (xk - xn) / dx;

            Assert.Equal(expected: massElemExpected, actual: counter);
        }

        [Theory]
        [InlineData(7.2, 4.2, 1.81, 5.31, 0.7)]

        public void TestTaskA_AllMoreThenZero(double a, double b, double xn, double xk, double dx)
        {
            var res = Program.TaskA(a, b, xn, xk, dx);
            int counter = 0;
            foreach (double elem in res)
            {
                if (elem > 0)
                {
                    counter++;
                }
            }

            double massElemExpected = (xk - xn) / dx;

            Assert.Equal(expected: massElemExpected, actual: counter);
        }

        [Theory]
        [InlineData(7.2, 4.2, 1.81, 5.31, 5)]

        public void TestTaskA_Steps(double a, double b, double xn, double xk, double dx)
        {
            var res = Program.TaskA(a, b, xn, xk, dx);
            int counter = 0;
            foreach (double elem in res)
            {
                    counter++;
            }

            Assert.Equal(expected: 1, actual: counter);
        }

        [Theory]
        [InlineData(4.1, 2.7)]
        public void TestTaskB(double a, double b)
        {
            double[] e = new double[0];
            var res = Program.TaskB(a, b, e);
            Assert.Equal(res, new double[0]);
        }
    }
}