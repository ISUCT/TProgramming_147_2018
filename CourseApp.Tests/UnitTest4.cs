using System;
using CourseApp;
using Xunit;

namespace CourseApp.Tests
{
    public class UnitTest4
    {
        [Fact]
        public void Test16()
        {
            Appliances[] appliances = new Appliances[2];
            appliances[0] = new Television();
            appliances[1] = new Microwave();
            foreach (Appliances i in appliances)
            {
                Assert.Equal(0, i.Vendorcode);
                Assert.Equal(0, i.Age);
            }
        }

        [Fact]
        public void Test17()
        {
            Appliances[] appliances = new Appliances[2];
            appliances[0] = new Television(132);
            appliances[1] = new Microwave(3);
            Assert.Equal(49620, appliances[0].Vendorcode);
            Assert.Equal(7, appliances[0].Age);
            Assert.Equal(414, appliances[1].Vendorcode);
            Assert.Equal(4, appliances[1].Age);
        }
    }
}
