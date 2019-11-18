using System;
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
        public void TestSetCol()
        {
            var item = new Dish();
            item.Col = 5;
            Assert.Equal(5, item.Col);
        }

        [Fact]

        public void TestIncorrectSetCol()
        {
            var item = new Dish();
            item.Col = -5;
            Assert.Equal(0, item.Col);
        }

        [Fact]
        public void TestCorrectIncorrectSetCol()
        {
            var item = new Dish();
            item.Col = 10;
            item.Col = -5;
            Assert.Equal(10, item.Col);
        }
    }
}
