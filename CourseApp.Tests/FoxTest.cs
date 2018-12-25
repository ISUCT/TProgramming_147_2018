using System;
using Xunit;
using Fauna;

namespace CourseApp.Tests
{
    public class FoxTest
    {
        [Fact]
        public void Test1()
        {
            Fox africa = new Fox("Neznaem", "White", 25, 30);
            Assert.Equal("Unknow", africa.Gender);
            Assert.Equal("White", africa.Color);
            Assert.Equal(25, africa.Weight);
            Assert.Equal(30, africa.Growth);
        }

        [Fact]
        public void Test2()
        {
            Fox europe = new Fox("Female", -15);
            Assert.Equal("Female", europe.Gender);
            Assert.Equal(0, europe.Weight);
        }

        [Fact]
        public void Test3()
        {
            Fox europe = new Fox("Koshka", -3);
            Assert.Equal("Unknow", europe.Gender);
            Assert.Equal(0, europe.Weight);
        }

        [Fact]
        public void Test4()
        {
            Fox europe = new Fox("Male", 28);
            Assert.Equal("Male", europe.Gender);
            Assert.Equal(28, europe.Weight);
        }

        [Fact]
        public void Test5()
        {
            Fox africa = new Fox("Male", "Blond", 13, -5);
            Assert.Equal("Male", africa.Gender);
            Assert.Equal("Blond", africa.Color);
            Assert.Equal(13, africa.Weight);
            Assert.Equal(0, africa.Growth);
        }

        [Fact]
        public void Test6()
        {
            Fox africa = new Fox("Neznaem", "", -25, -30);
            Assert.Equal("Unknow", africa.Gender);
            Assert.Equal("UnknowColor", africa.Color);
            Assert.Equal(0, africa.Weight);
            Assert.Equal(0, africa.Growth);
        }

        [Fact]
        public void Test7()
        {
            Fox africa = new Fox("Male", "555", 15, 20);
            Assert.Equal("Male", africa.Gender);
            Assert.Equal("UnknowColor", africa.Color);
            Assert.Equal(15, africa.Weight);
            Assert.Equal(20, africa.Growth);
        }
    }
}