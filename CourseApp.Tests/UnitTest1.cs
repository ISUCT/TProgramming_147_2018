using System;
using Xunit;
using Matan;
namespace CourseApp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = Program.y1(0);
            Assert.Equal(1.57, res, 2);
        }

        [Fact]
        public void Test2()
        {
            var res = Program.y1(1);
            Assert.Equal(0.2, res, 1);
        }
        [Fact]
        public void Test3()
        {
            var res = Program.y1(-1);
            Assert.Equal(Double.NaN, res);
        }
        [Fact]
        public void Test4()
        {
            var res = Program.y1(2);
            Assert.Equal(-0.86, res, 2);
        }
        [Fact]
        public void Test5()
        {
            var res = Program.y1(-2);
            Assert.Equal(Double.NaN, res);
        }
        [Fact]
        public void Test6()
        {
            var res = Program.y1(3);
            Assert.Equal(-2.01, res, 2);
        }
        [Fact]
        public void Test7()
        {
            var res = Program.y1(-3);
            Assert.Equal(Double.NaN, res);
        }
        [Fact]
        public void Test8()
        {
            var res = Program.y1(4);
            Assert.Equal(-3.2, res, 2);
        }
        [Fact]
        public void Test9()
        {
            var res = Program.y1(-4);
            Assert.Equal(Double.NaN, res);
        }
        [Fact]
        public void Test10()
        {
            var res = Program.y1(5);
            Assert.Equal(-4.41, res, 2);
        }
    }

}
