using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(0, 0, 0, 0)]

        public void TestFunctionZeroVal(double a, double b, double x, double exp)
        {
            var res = Program.MyFunction(a, b, x);
            Assert.Equal(exp, res, 3);
        }

        [Theory]
        [InlineData(7.2, 4.2, 1.81, 5.31, 0.7)]

        public void TestMoreThenZero(double a, double b, double xn, double xk, double dx)
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

            Assert.Equal(5, counter);
        }
    }
}
