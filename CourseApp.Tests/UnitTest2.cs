using System;
using Xunit;
using ConsoleApp2;

namespace CourseApp.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void Check4Konstruktor()
        {
            Shcaf shcaf1 = new Shcaf("Russia", "Shcafishe", "дуб");
            Assert.Equal("Russia", shcaf1.Produced);
            Assert.Equal(9, shcaf1.Name.Length);
            Assert.Equal("Shcafishe", shcaf1.Name);
            Assert.Equal("дуб", shcaf1.Material);
        }

        [Fact]
        public void CheckSecondKonstruktor1()
        {
            Stol stol2 = new Stol("Russia", 160, 230);
            Assert.Equal("Russia", stol2.Produced);
            Assert.Equal(6, stol2.Name.Length);
            Assert.Equal("Noname", stol2.Name);
            Assert.Equal(160, stol2.Lenght);
            Assert.Equal(230, stol2.Height);
        }

        [Fact]
        public void CheckSecondKonstruktor2()
        {
            Stol stol2 = new Stol("German", "Best Stol", 300, 140);
            Assert.Equal("German", stol2.Produced);
            Assert.Equal(9, stol2.Name.Length);
            Assert.Equal("Best Stol", stol2.Name);
            Assert.Equal(300, stol2.Lenght);
            Assert.Equal(140, stol2.Height);
        }

        [Fact]
        public void CheckFirstKonstruktor1()
        {
            Stol stol1 = new Stol("Poland", "Supastol", 150, 100);
            Assert.Equal("Poland", stol1.Produced);
            Assert.Equal("Supastol", stol1.Name);
            Assert.Equal(150, stol1.Lenght);
            Assert.Equal(100, stol1.Height);
        }

        [Fact]
        public void CheckFirstKonstruktor3()
        {
            Stol stol1 = new Stol(string.Empty, "Stol Mechta", 300, 140);
            Assert.Equal(string.Empty, stol1.Produced);
            Assert.Equal("Stol Mechta", stol1.Name);
            Assert.Equal(300, stol1.Lenght);
            Assert.Equal(140, stol1.Height);
        }

        [Fact]
        public void CheckSettersNegative1()
        {
            Stol stol2 = new Stol("Poland", 160, 200);
            Assert.Equal("Poland", stol2.Produced);
            Assert.Equal(160, stol2.Lenght);
            Assert.Equal(200, stol2.Height);
            stol2.Lenght = -260;
            Assert.Equal(160, stol2.Lenght);
        }

        [Fact]
        public void CheckSettersNegative2()
        {
            Stol stol2 = new Stol("Russia", 160, 200);
            Assert.Equal("Russia", stol2.Produced);
            Assert.Equal(160, stol2.Lenght);
            Assert.Equal(200, stol2.Height);
            stol2.Height = -250;
            Assert.Equal(200, stol2.Height);
        }

        [Fact]
        public void CheckSettersPositive1()
        {
            Stol stol2 = new Stol("Russia", 160, 200);
            Assert.Equal("Russia", stol2.Produced);
            Assert.Equal(160, stol2.Lenght);
            Assert.Equal(200, stol2.Height);
            stol2.Lenght = 299;
            Assert.Equal(299, stol2.Lenght);
        }

        [Fact]
        public void CheckSettersPositive2()
        {
            Stol stol2 = new Stol("Russia", 160, 200);
            Assert.Equal("Russia", stol2.Produced);
            Assert.Equal(160, stol2.Lenght);
            Assert.Equal(200, stol2.Height);
            stol2.Height = 159;
            Assert.Equal(159, stol2.Height);
        }

        [Fact]
        public void CheckGetinfo1()
        {
            Stol stol1 = new Stol("Russia", "Supastol", 160, 200);
            var tmp1 = stol1.ToString();
            var exp = "Произведенно в : Russia Имя: Supastol  Длина: 160  Высота: 200";
            Assert.Equal(exp, stol1.GetInfo());
        }

        [Fact]
        public void CheckGetinfo2()
        {
            Shcaf shcaf1 = new Shcaf("Russia", "Supastol", "береза");
            var tmp = shcaf1.ToString();
            var exp = "Произведенно в:Russia Имя:Supastol Материал:береза";
            Assert.Equal(exp, shcaf1.GetInfo());
        }
    }
}