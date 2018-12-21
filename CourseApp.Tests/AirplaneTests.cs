using System;
using Xunit;
using Samolet;

namespace CourseApp.Tests
{
    public class AirplaneTests
    {
        [Fact]
        public void Test1()
        {
            Airplane airplane1 = new Airplane(700, "samoletik");
            Assert.Equal(700, airplane1.Speed);
            Assert.Equal("samoletik", airplane1.Name);
        }

        [Fact]
        public void Test2()
        {
            Airplane airplane1 = new Airplane(700);
            Assert.Equal(700, airplane1.Speed);
        }

        [Fact]
        public void Test3()
        {
            Airplane airplane2 = new Airplane(700);
            Assert.Equal(700, airplane2.Speed);
        }

        [Fact]
        public void Test4()
        {
            Airplane airplane2 = new Airplane(700);
            Assert.Equal(700, airplane2.Speed);
            airplane2.Speed = 500;
            Assert.Equal(500, airplane2.Speed);
        }

        [Fact]
        public void TestNameSet()
        {
            Airplane airplane2 = new Airplane(700);
            airplane2.Name = "Plane";
            Assert.Equal("Plane", airplane2.Name);
        }

        [Fact]
        public void TestNegativeSpeed()
        {
            Airplane airplane2 = new Airplane(700);
            Assert.Equal(700, airplane2.Speed);
            airplane2.Speed = -500;
            Assert.Equal(700, airplane2.Speed);
        }

        [Fact]
        public void TestGetInfo()
        {
            Airplane airplane2 = new Airplane(700);
            var exp = "Имя: Noname  Скорость: 700";
            Assert.Equal(exp, airplane2.GetInfo());
        }

        [Fact]
        public void TestNegativeSpeedInConstructor()
        {
            Airplane airplane2 = new Airplane(-700);
            Assert.Equal(0, airplane2.Speed);
        }
    }
}
