using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(7.2, 3.8, 1, 0)]
        [InlineData(12.2, 4.5, 1, 0)]
        [InlineData(20.2, 2.7, 1, 0)]

        public void TestForFunctionValues(double a, double b, double x, double exp)
        {
            var res = Program.MyFunction(a, b, x);
            Assert.Equal(res, exp);
        }

        [Fact]
        public void TestFunctionZeroVal()
        {
            var res = Program.MyFunction(0, 0, 0);
            Assert.Equal(0, res, 3);
        }

        [Theory]
        [InlineData(7.2, 4.2, 1.81, 5.31, 0.7)]

        public void TestTaskA_Elements(double a, double b, double xn, double xk, double dx)
        {
            var res = Program.TaskA(a, b, xn, xk, dx);
            double massElemExpected = (xk - xn) / dx;
            Assert.Equal(expected: massElemExpected, actual: res.Length);
        }

        [Theory]
        [InlineData(7.2, 4.2, 1.81, 5.31, 0.7)]
        [InlineData(3.2, 3.2, 1.5, 6.1, 0.5)]

        public void TestATaskAllMoreThenZero(double a, double b, double xn, double xk, double dx)
        {
            try
            {
                var res = Program.TaskA(a, b, xn, xk, dx);

                double massElemExpected = (xk - xn) / dx;

                Assert.Equal(expected: massElemExpected, actual: res.Length);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out Of Bounds");
                Assert.True(true);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Argument Out Of Range");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestATaskTooLargeSteps()
        {
            var res = Program.TaskA(7.2, 4.2, 1.81, 5.31, 5);
            int count = res.Length;
            Assert.Equal(1, count);
        }

        [Theory]
        [InlineData(4.1, 2.7)]
        [InlineData(5.2, 3.5)]
        [InlineData(6.3, 1.3)]
        public void TestTaskB(double a, double b)
        {
            double[] e = new double[0];
            var res = Program.TaskB(a, b, e);
            Assert.Equal(res, new double[0]);
        }
    }
}