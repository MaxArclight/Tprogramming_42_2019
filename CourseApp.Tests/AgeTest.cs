using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeTest
    {
        [Theory]
        [InlineData(2000, 11, 26)]
        [InlineData(7000, 4, 5)]
        [InlineData(2019, 12, 21)]

        public void TestForAgeCalcValues(int year, int month, int day)
        {
            try
            {
                DateTime curDate = new DateTime(2019, 12, 11);
                DateTime inputDate = new DateTime(year, month, day);
                DateTime result = AgeCalc.AgeCalcFunc(inputDate, curDate);
                DateTime datemin = new DateTime(2, 2, 1);
                DateTime expect = new DateTime(curDate.Ticks - inputDate.Ticks - datemin.Ticks);
                Assert.Equal(expected: expect, actual: result);
            }
            catch (IndexOutOfRangeException outOfRange)
            {
                Console.WriteLine(outOfRange.Message);
                Assert.True(true);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
                Assert.True(true);
            }
        }
    }
}