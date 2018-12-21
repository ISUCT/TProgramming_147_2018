using System;
using Xunit;
using ConsoleApp3;

namespace CourseApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = Program.Y(0, 0, 0);
            Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void Test2()
        {
            var res = Program.Y(2, 1, 4);
            Assert.Equal(0, res);
        }

        [Fact]
        public void Test3()
        {
            var res = Program.Y(2, 0, 0);
            Assert.Equal(0, res);
        }

        [Fact]
        public void Test4()
        {
            var res = Program.Y(1, 0, 0);
            Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void Test5()
        {
            var res = Program.Y(3, 0, 0);
            Assert.Equal(0, res);
        }

        [Fact]
        public void Test6()
        {
            var res = Program.Y(0, 1, 0);
            Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void Test7()
        {
            var res = Program.Y(0, 0, 1);
            Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void Test8()
        {
            var res = Program.Y(1, 1, 1);
            Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void Test9()
        {
            var res = Program.Y(10, 0.1, 0);
            Assert.Equal(1.395, res, 3);
        }

        [Fact]
        public void Test10()
        {
            var res = Program.Y(20, 0, -1);
            Assert.Equal(double.PositiveInfinity, res);
        }

        [Fact]
        public void Test11()
        {
            var res = Program.Y(-1, 1, -1);
            Assert.Equal(double.NegativeInfinity, res);
        }
    }
}
