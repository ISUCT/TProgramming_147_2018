using System;
using Xunit;
using ConsoleApp2;

namespace CourseApp.Tests
{
    public class UnitTest3
    {
        [Fact]
        public void TestMassive()
        {
            Furniture[] furniture = new Furniture[2];
            furniture[0] = new Stol();
            furniture[1] = new Shcaf();
            foreach (Furniture i in furniture)
            {
                Assert.Equal("Russia", i.Produced);
                Assert.Equal("chto-to", i.Name);
            }
        }

        [Fact]
        public void TestElementInMassive()
        {
            Furniture[] furniture = new Furniture[2];
            furniture[0] = new Stol(200, 100);
            furniture[1] = new Shcaf("Polsha", "derevo");
            Assert.Equal(100, furniture[0].Height);
            Assert.Equal(200, furniture[0].Lenght);
            Assert.Equal("Polsha", furniture[1].Produced);
            Assert.Equal("derevo", furniture[1].Material);
        }
    }
}