using System;
using Xunit;
using Matan;

namespace CourseApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = Program.y(1, 1, 0);
            Assert.Equal(Double.NaN, res);            
        }
        [Fact]
        public void Test2()
        {
            var res = Program.y(1, 0, 1);
            Assert.Equal(1, res);
        }
        [Fact]
        public void Test3()
        {
            var res = Program.y(0, 0, 0);
            Assert.Equal(Double.PositiveInfinity, res);
        }
        [Fact]
        public void Test4()
        {
            var res = Program.y(1, 0, 0);
            Assert.Equal(0, res);
        }
        [Fact]
        public void Test5()
        {
            var res = Program.y(1, 1, 1);
            Assert.Equal(Double.PositiveInfinity, res);
        }
        [Fact]
        public void Test6()
        {
            var res = Program.y(0, 1, 1);
            Assert.Equal(-2, res);
        }
        [Fact]
        public void Test7()
        {
            var res = Program.y(0, 0, 1);
            Assert.Equal(Double.PositiveInfinity, res);
        }
        [Fact]
        public void Test8()
        {
            var res = Program.y(0, 1, 0);
            Assert.Equal(-1, res);
        }
    }
}
