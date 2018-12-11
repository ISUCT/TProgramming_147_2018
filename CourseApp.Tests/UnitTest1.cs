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
            var res = Program.Y(1, 1, (double)0);
            Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void Test2()
        {
            var res = Program.Y(1, 0, (double)1);
            Assert.Equal(1, res);
        }

        [Fact]
        public void Test3()
        {
            var res = Program.Y(0, 0, (double)0);
            Assert.Equal(double.PositiveInfinity, res);
        }

        [Fact]
        public void Test4()
        {
            var res = Program.Y(1, 0, (double)0);
            Assert.Equal(0, res);
        }

        [Fact]
        public void Test5()
        {
            var res = Program.Y(1, 1, (double)1);
            Assert.Equal(double.PositiveInfinity, res);
        }

        [Fact]
        public void Test6()
        {
            var res = Program.Y(0, 1, (double)1);
            Assert.Equal(-2, res);
        }

        [Fact]
        public void Test7()
        {
            var res = Program.Y(0, 0, (double)1);
            Assert.Equal(double.PositiveInfinity, res);
        }

        [Fact]
        public void Test8()
        {
            var res = Program.Y(0, 1, (double)0);
            Assert.Equal(-1, res);
        }
    }
}
