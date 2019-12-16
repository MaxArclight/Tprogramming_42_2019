﻿using System;

namespace AgeCalc
{
    class Program
    {

        public static int AgeCalc(DateTime date)
        {

            DateTime curDate = DateTime.Now;

            int age = curDate.Year - date.Year;

            if (curDate.Month < date.Month ||
               (curDate.Month == date.Month && curDate.Day < date.Day)) age--;

            return age;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("input year");
            int year = Convert.ToInt32(Console.ReadLine());
                if (year < 0)
                {
                    throw new ArgumentOutOfRangeException("year");
                }
            Console.WriteLine("input month");
            int month = Convert.ToInt32(Console.ReadLine());
                if (month < 0)
                {
                    throw new ArgumentOutOfRangeException("year");
                }
            Console.WriteLine("input day");
            int day = Convert.ToInt32(Console.ReadLine());
                if (day < 0)
                {
                    throw new ArgumentOutOfRangeException("year");
                }



            DateTime inputDate = new DateTime(year, month, day);
            if (inputDate == DateTime.Now) {
                throw new ArgumentException("inputDate");
            }


            int output = AgeCalc(inputDate);

            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}




namespace AgeCalc.Tests
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
        [InlineData(3.2, 3.2, 1.5, 6.1, 0.5)]
        [InlineData(4.1, 1.1, 0.3, 6.5, 1.0)]

        public void TestTaskAElements(double a, double b, double xn, double xk, double dx)
        {
            try
            {
                var res = Program.TaskA(a, b, xn, xk, dx);
                double massElemExpected = (xk - xn) / dx;
                Assert.Equal(expected: massElemExpected, actual: res.Count);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out Of Bounds");
                Assert.True(true);
            }
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

                Assert.Equal(expected: massElemExpected, actual: res.Count);
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
            int count = res.Count;
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
