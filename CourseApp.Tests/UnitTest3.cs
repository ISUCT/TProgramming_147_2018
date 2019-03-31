using System;
using Xunit;
using ConsoleApp2;
using static ConsoleApp2.Furniture;

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

        [Fact]
        public void TestIComparable1()
        {
            Furniture[] furnitur = new Furniture[2];
            furnitur[0] = new Stol("B");
            furnitur[1] = new Shcaf("Aljir");
            Array.Sort(furnitur);
            Assert.Equal("Aljir", furnitur[0].Name);
        }

        [Fact]
        public void TestIComparable2()
        {
            Furniture[] furnitur = new Furniture[4];
            furnitur[0] = new Stol("Ru");
            furnitur[1] = new Shcaf("Ge");
            furnitur[2] = new Shcaf("Al");
            furnitur[3] = new Stol("Be");
            Array.Sort(furnitur);
            Assert.Equal("Al", furnitur[0].Name);
            Assert.Equal("Be", furnitur[1].Name);
            Assert.Equal("Ge", furnitur[2].Name);
            Assert.Equal("Ru", furnitur[3].Name);
        }

        [Fact]
        public void TestIComparable3()
        {
            Furniture[] furnitur = new Furniture[4];
            furnitur[0] = new Stol("1");
            furnitur[1] = new Shcaf("A");
            furnitur[2] = new Shcaf("S");
            furnitur[3] = new Stol("2");
            Array.Sort(furnitur);
            Assert.Equal("1", furnitur[0].Name);
            Assert.Equal("2", furnitur[1].Name);
            Assert.Equal("A", furnitur[2].Name);
            Assert.Equal("S", furnitur[3].Name);
        }

        [Fact]
        public void TestIPrint1()
        {
            Stol stol2 = new Stol("Russia", 160, 200);
            Assert.Equal("Stol", stol2.Mebel());
        }

        [Fact]
        public void TestIPrint2()
        {
            Shcaf shcaf1 = new Shcaf("Russia", "Supastol", "береза");
            Assert.Equal("Schaf", shcaf1.Mebel());
        }

        [Fact]
        public void TestIPrint3()
        {
            Stol stol3 = new Stol("Russia", 200, 200);
            Assert.Equal(40000, stol3.Ploshad());
        }

        [Fact]
        public void TestIPrint4()
        {
            Stol stol1 = new Stol("Rus", 160, 200);
            Assert.Equal(32000, stol1.Ploshad());
        }
    }
}