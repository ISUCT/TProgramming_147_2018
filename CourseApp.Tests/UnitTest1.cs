using System;
using Xunit;
using ConsoleApp5;

namespace CourseApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = Program.y(0, 1, 1); //x, a, b
            Assert.Equal(Double.PositiveInfinity, res);
        }
        [Fact]
        public void Test2()
        {
            var res = Program.y(1, 1, Math.E);
            Assert.Equal(Double.PositiveInfinity, res);
        }
        [Fact]
        public void Test3()
        {
            var res = Program.y(0, 0, 0);
            Assert.Equal(Double.NaN, res);
        }
        [Fact]
        public void Test4()
        {
            var res = Program.y(0, 0, 1);
            Assert.Equal(Double.NaN, res);
        }
        [Fact]
        public void Test5()
        {
            var res = Program.y(0, 1, -1);
            Assert.Equal(Double.NegativeInfinity, res);
        }
        
    }
}