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
            var res = Program3.Y(0, 0);
            Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void Test2()
        {
            var res = Program3.Y(2, 1);
            Assert.Equal(1.2, res, 1 );
        }

        [Fact]
        public void Test3()
        {
            var res = Program3.Y(2, 0);
            Assert.Equal(0.48, res, 2);
        }

        [Fact]
        public void Test4()
        {
            var res = Program3.Y(1, 0);
            Assert.Equal(0, res);
        }

        [Fact]
        public void Test5()
        {
            var res = Program3.Y(3, 0);
            Assert.Equal(1.207, res, 3);
        }

        [Fact]
        public void Test6()
        {
            var res = Program3.Y(0, 1);
            Assert.Equal(0, res, 0);
        }

        [Fact]
        public void Test7()
        {
            var res = Program3.Y(0, 2);
            Assert.Equal(0.48, res, 2 );
        }

        [Fact]
        public void Test8()
        {
            var res = Program3.Y(1, 1);
            Assert.Equal(0.48, res, 2);
        }

        [Fact]
        public void Test9()
        {
            var res = Program3.Y(10, 0.1);
            Assert.Equal(5.348, res, 3);
        }

        [Fact]
        public void Test10()
        {
            var res = Program3.Y(20, 0);
            Assert.Equal(8.974, res, 3 );
        }

        [Fact]
        public void Test11()
        {
            var res = Program3.Y(-1, 1);
            Assert.Equal(double.NaN, res);
        }
    }
}
