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
            var res = Program.y(1,1,1);
            Assert.Equal(3.085, res);            
        }
        [Fact]
        public void Test2()
        {
            var res = Program.y(0,0,1);
            Assert.Equal(3.085, res, 3);
        }
        [Fact]
        public void Test3()
        {
            var res = Program.y(0,1,1);
            Assert.Equal(5.065, res);
        }
        [Fact]
        public void Test4()
        {
            var res = Program.y(1,0,1);
            Assert.Equal(0, res);
        }
        [Fact]
        public void Test5()
        {
            var res = Program.y(2,5,4);
            Assert.Equal(Double.PositiveInfinity, res);
        }
        [Fact]
        public void Test6()
        {
            var res = Program.y(3,7,6);
            Assert.Equal(-2, res);
        }
    }
}