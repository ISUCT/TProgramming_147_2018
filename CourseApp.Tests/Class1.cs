using System;
using Xunit;
using ConsoleApp2;
namespace CourseApp.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void CheckSecondKonstruktor1()
        {
            Car car2 = new Car("tesla", 230);
            Assert.Equal("tesla", car2.Name);
            Assert.Equal(230, car2.Speed);

        }
        [Fact]
        public void CheckSecondKonstruktor2()
        {
            Car car2 = new Car("zhigul", 155);
            Assert.Equal("zhigul", car2.Name);
            Assert.Equal(155, car2.Speed);

        }
    }
} 