using System;
using Xunit;
using Matem;
namespace CourseApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = Program.y(0, 0, 0);
            Assert.Equal(0, res);
        }
        [Fact]
        public void Test2()
        {
            var res = Program.y(2, 1, 4);
            Assert.Equal(11.035, res, 3);
        }
        [Fact]
        public void Test3()
        {
            var res = Program.y(4, 2, 1);
            Assert.Equal(2.759, res, 3);
        }
        [Fact]
        public void Test4()
        {
            var res = Program.y(5, 3, 2);
            Assert.Equal(2.047, res, 3);

        }
        [Fact]
        public void Test5()
        {
            var res = Program.y(3, 0, 0);
            Assert.Equal(4.393, res, 3);

        }
        [Fact]
        public void Test6()
        {
            var res = Program.y(7, 4, 2);
            Assert.Equal(1.400, res, 3);

        }
        [Fact]
        public void Test7()
        {
            var res = Program.y(0, 5, 0);
            Assert.Equal(0, res,  3);

        }
        [Fact]
        public void Test8()
        {
            var res = Program.y(0, 1, 0);
            Assert.Equal(0, res,  3);

        }
        [Fact]
        public void Test9()
        {
            var res = Program.y(10, 0.1, 0);
            Assert.Equal(1, res, 3);

        }
        [Fact]
        public void Test10()
        {
            var res = Program.y(0, 2, -1);
            Assert.Equal(0, res, 3);

        }
        [Fact]
        public void Test11()
        {
            var res = Program.y(0, 0, 3);
            Assert.Equal(0, res, 3);

        }
    }



}