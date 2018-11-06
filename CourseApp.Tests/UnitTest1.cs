using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = Program.y(4);
            Assert.Equal(Double.NaN, res);            
        }
        [Fact]
        public void Test2()
        {
            var res = Program.y(-5);
            Assert.Equal(1, res);
        }
        [Fact]
        public void Test3()
        {
            var res = Program.y(0);
            Assert.Equal(Double.PositiveInfinity, res);
        }
        [Fact]
        public void Test4()
        {
            var res = Program.y(1,25;
            Assert.Equal(0, res);
        }
        [Fact]
        public void Test5()
        {
            var res = Program.y(-1,5);
            Assert.Equal(Double.PositiveInfinity, res);
        }
        [Fact]
        public void Test6()
        {
            var res = Program.y(3,75);
            Assert.Equal(-2, res);
        }
    }
}