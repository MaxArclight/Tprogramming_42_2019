using Xunit;

namespace CourseApp.Tests
{
    public class DishTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Dish();
            Assert.Equal(0, item.Weight);
            Assert.Equal("Untitled", item.Name);
            Assert.True(item.IsReady);
        }

        [Fact]
        public void TestSetWeight()
        {
            var item = new Dish();
            item.Weight = 5;
            Assert.Equal(5, item.Weight);
        }

        [Fact]
        public void TestIncorrectSetWeight()
        {
            var item = new Dish();
            item.Weight = -5;
            Assert.Equal(0, item.Weight);
        }

        [Fact]
        public void TestCorrectIncorrectSetWeight()
        {
            var item = new Dish();
            item.Weight = 10;
            item.Weight = -5;
            Assert.Equal(10, item.Weight);
        }

        [Fact]
        public void TestSetCal()
        {
            var item = new Dish();
            item.Cal = 5;
            Assert.Equal(5, item.Cal);
        }

        [Fact]
        public void TestCorrectIncorrectSetCal()
        {
            var item = new Dish();
            item.Cal = 10;
            item.Cal = -5;
            Assert.Equal(10, item.Cal);
        }
    }
}