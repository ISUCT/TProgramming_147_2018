using System;
using Xunit;
using ConsoleApp2;

namespace CourseApp.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void CheckSecondKonstruktor1()
        {

            Stol stol2 = new Stol(160, 230);
            Assert.Equal(6, stol2.Name.Length);
            Assert.Equal("Noname", stol2.Name);
            Assert.Equal(160, stol2.Lenght);
            Assert.Equal(230, stol2.Height);

        }
        [Fact]
        public void CheckSecondKonstruktor2()
        {

            Stol stol2 = new Stol(300, 140);
            Assert.Equal(6, stol2.Name.Length);
            Assert.Equal("Noname", stol2.Name);
            Assert.Equal(300, stol2.Lenght);
            Assert.Equal(140, stol2.Height);
        }
        [Fact]
        public void CheckFirstKonstruktor1()
        {

            Stol stol1 = new Stol("Supastol", 150, 100);
            Assert.Equal("Supastol", stol1.Name);
            Assert.Equal(150, stol1.Lenght);
            Assert.Equal(100, stol1.Height);
        }

        [Fact]
        public void CheckFirstKonstruktor2()
        {

            Stol stol1 = new Stol("123", 200, 110);
            Assert.Equal("123", stol1.Name);
            Assert.Equal(200, stol1.Lenght);
            Assert.Equal(110, stol1.Height);
        }
        [Fact]
        public void CheckFirstKonstruktor3()
        {

            Stol stol1 = new Stol("", 300, 140);
            Assert.Equal("", stol1.Name);
            Assert.Equal(300, stol1.Lenght);
            Assert.Equal(140, stol1.Height);
        }
        [Fact]
        public void CheckSettersNegative1()
        {

            Stol stol2 = new Stol(160, 200);
            Assert.Equal(160, stol2.Lenght);
            Assert.Equal(200, stol2.Height);
            stol2.Lenght = -260;
            Assert.Equal(160, stol2.Lenght);
        }
        [Fact]
        public void CheckSettersNegative2()
        {

            Stol stol2 = new Stol(160, 200);
            Assert.Equal(160, stol2.Lenght);
            Assert.Equal(200, stol2.Height);
            stol2.Height = -250;
            Assert.Equal(200, stol2.Height);
        }
        [Fact]
        public void CheckSettersPositive1()
        {
            Stol stol2 = new Stol(160, 200);
            Assert.Equal(160, stol2.Lenght);
            Assert.Equal(200, stol2.Height);
            stol2.Lenght = 299;
            Assert.Equal(299, stol2.Lenght);
        }
        [Fact]
        public void CheckSettersPositive2()
        {
            Stol stol2 = new Stol(160, 200);
            Assert.Equal(160, stol2.Lenght);
            Assert.Equal(200, stol2.Height);
            stol2.Height = 159;
            Assert.Equal(159, stol2.Height);
        }
        [Fact]
        public void CheckGetinfo1()
        {
            Stol stol1 = new Stol("Supastol", 160, 200);
            var exp = "Имя: Supastol  Длина: 160  Высота: 200";
            Assert.Equal(exp, stol1.GetInfo());
        }
    }
}