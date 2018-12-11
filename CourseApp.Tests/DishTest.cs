using System;
using Xunit;
using Menu;

namespace CourseApp.Tests
{
    public class DishTest
    {

        [Fact]
        public void Test1()
        {

            Dish salad = new Dish("Cesar", 500, "Salad", 250);
            Assert.Equal("Cesar", salad.Name);
            Assert.Equal(500, salad.Price);
            Assert.Equal("Salad", salad.Type);
            Assert.Equal(250, salad.Weight);
            
        }

        [Fact]
        public void Test2()
        {

            Dish soup = new Dish("chees", 250);
            Assert.Equal("chees", soup.Name);
            Assert.Equal(250, soup.Price);

        }
        [Fact]
        public void Test3()
        {

            Dish soup = new Dish("chees", -3);
            Assert.Equal("chees", soup.Name);
            Assert.Equal(-3, soup.Price);

        }


    }
}

