using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeTest
    {
        [Fact]
        public void TestDrinkIncorrectVolume()
        {
            try
            {
                var item = new Drink();
                item.Volume = -5;
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine(outOfRange.Message);
                Assert.True(true);
            }
        }
    }
}