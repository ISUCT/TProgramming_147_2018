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
            Pig pig1 = new Pig(15, 150);
            Assert.Equal(6, pig1.Weight);
            Assert.Equal("Noname", pig1.Name);
            Assert.Equal(15, pig1.Age);
            Assert.Equal(150, pig1.Weight);
         }
        [Fact]

         public void CheckSecondKonstruktor2()
         {
             Pig Pig2 = new pig(21, 215);
           Assert.Equal(9, Pig2.Name.weight);
            Assert.Equal("Toto", Pig2.Name);
            Assert.Equal(21, Pig2.age);
            Assert.Equal(215, Pig2.weight);
          }
         [Fact]
         public void CheckSecondKonstruktor3()
        {
             Pig Pig3 = new pig(20, 210);
             Assert.Equal(4, Pig3.Name.weight);
             Assert.Equal("Okta", Pig10.Name);
             Assert.Equal(21, Pig10.age);
             Assert.Equal(215, Pig10.weight);
         } 
         [Fact]
         public void CheckSecondKonstruktor4()
         {
            Pig Pig4 = new pig(25, 350);
            Assert.Equal(5, Pig4.Name.weight);
             Assert.Equal("Fufa", Pig4.Name);
             Assert.Equal(25, Pig4.age);
            Assert.Equal(350, Pig4.weight);
          }
         [Fact]
         public void CheckSecondKonstruktor5()
         {
            Pig Pig5 = new pig(25, 350);
             Assert.Equal(8, Pig5.Name.weight);
             Assert.Equal("Tufa", Pig5.Name);
             Assert.Equal(25, Pig5.age);
             Assert.Equal(350, Pig5.weight);
         } 
    }
 }