using System;
using Xunit;
using ConsoleApp1;

namespace CourseApp.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void TestMassive()
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Dog();
            animals[1] = new Cat();
            foreach (Animal i in animals)
            {
                Assert.Equal("Black", i.Color);
                Assert.Equal(1, i.Age);
            }
        }

        [Fact]
        public void TestElementInMassive()
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Dog("Bulldog","Jack", 5);
            animals[1] = new Cat("Persian", "White");
            Assert.Equal("Bulldog", animals[0].Breed);
            Assert.Equal("Jack", animals[0].Name);
            Assert.Equal(5, animals[0].Age);
            Assert.Equal("Persian", animals[1].Breed);
            Assert.Equal("White", animals[1].Color);
        }
    }
}