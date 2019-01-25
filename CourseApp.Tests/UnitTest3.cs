using System;
using CourseApp;
using Xunit;

namespace CourseApp.Tests
{
    public class UnitTest3
    {
        [Fact]
        public void Test12()
        {
            Microwave rg = new Microwave();
            Assert.Equal(800, rg.Voltage);
            Assert.Equal(0, rg.Vendorcode);
            Assert.Equal(0, rg.Age);
        }

        [Fact]
        public void Test13()
        {
            Microwave rg = new Microwave(7);
            Assert.Equal(7, rg.Voltage);
            Assert.Equal(414, rg.Vendorcode);
            Assert.Equal(4, rg.Age);
        }

        [Fact]
        public void Test14()
        {
            Microwave rg = new Microwave(-5, 414, 8);
            Assert.Equal(0, rg.Voltage);
            Assert.Equal(414, rg.Vendorcode);
            Assert.Equal(8, rg.Age);
        }

        [Fact]
        public void Test15()
        {
            Microwave rg = new Microwave(700, 414, 4);
            Assert.Equal("\nМикроволновка включена", rg.Status());
            Assert.Equal($"Напряжение в микроволновке: {rg.Voltage} Вт, Артикул {rg.Vendorcode}, Возраст микроволновки: {rg.Age}. ", rg.ToString());
        }
    }
}
