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
            var res = Program.Y(0, 0, 1);
            Assert.Equal(Double.NaN, res);            
        }
        [Fact]
        public void Test2()
        {
            var res = Program.Y(2, 0, 1);
            Assert.Equal(2.39014261372843, res);
        }
        [Fact]
        public void Test3()
        {
            var res = Program.Y(0, 0, 0);
            Assert.Equal(Double.PositiveInfinity, res);
        }
        [Fact]
        public void Test4()
        {
            var res = Program.Y(1, 0, 0);
            Assert.Equal(2, res);
        }
        [Fact]
        public void Test5()
        {
            var res = Program.Y(1, 2, 1);
            Assert.Equal(Double.NaN, res);
        }
        [Fact]
        public void Test6()
        {
            var res = Program.Y(0, 1, 1);
            Assert.Equal(Double.NaN, res);
        }
    }
}