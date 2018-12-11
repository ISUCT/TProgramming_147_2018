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
            Pig Pig12 = new pig(15, 150);
            Assert.Equal(6, Pig12.Name.weight);
            Assert.Equal("Noname", Pig12.Name);
            Assert.Equal(15, Pig12.age);
            Assert.Equal(150, Pig12.weight);
         }
        [Fact]
        public void CheckSecondKonstruktor2()
        {
            Pig Pig12 = new Pig(15, 150);
            Assert.Equal(6, Pig12.Name.weight);
            Assert.Equal("Noname", Pig12.Name);
            Assert.Equal(15, Pig12.age);
            Assert.Equal(150, Pig12.weight);
        }
         [Fact]
        public void CheckSecondKonstruktor1()
        {
            Pig Pig11 = new pig(19, 180);
            Assert.Equal(6, Pig11.Name.weight);
            Assert.Equal("Tuka", Pig11.Name);
            Assert.Equal(19, Pig11.age);
            Assert.Equal(180, Pig11.weight);
         }
        [Fact]
        public void CheckSecondKonstruktor2()
        {
             
            Pig Pig11 = new pig(19, 180);
            Assert.Equal(6, Pig11.Name.weight);
            Assert.Equal("Tuka", Pig11.Name);
            Assert.Equal(19, Pig11.age);
            Assert.Equal(180, Pig11.weight);
        } 
        [Fact]
        public void CheckSecondKonstruktor1()
        {
            Pig Pig10 = new pig(21, 215);
            Assert.Equal(6, Pig10.Name.weight);
            Assert.Equal("Noname", Pig10.Name);
            Assert.Equal(21, Pig10.age);
            Assert.Equal(215, Pig10.weight);
         }
        [Fact]
        public void CheckSecondKonstruktor2()
        {
            Pig Pig10 = new pig(21, 215);
            Assert.Equal(6, Pig10.Name.weight);
            Assert.Equal("Noname", Pig10.Name);
            Assert.Equal(21, Pig10.age);
            Assert.Equal(215, Pig10.weight);
        } 
        [Fact]
        public void CheckSecondKonstruktor1()
        {
            Pig Pig9 = new pig(25, 350);
            Assert.Equal(6, Pig9.Name.weight);
            Assert.Equal("Fufa", Pig9.Name);
            Assert.Equal(25, Pig9.age);
            Assert.Equal(350, Pig9.weight);
         }
        [Fact]
        public void CheckSecondKonstruktor2()
        {
            Pig Pig9 = new pig(25, 350);
            Assert.Equal(6, Pig9.Name.weight);
            Assert.Equal("Fufa", Pig9.Name);
            Assert.Equal(25, Pig9.age);
            Assert.Equal(350, Pig9.weight);
        } 
        [Fact]
        public void CheckSecondKonstruktor1()
        {
            Pig Pig8 = new pig(22, 270);
            Assert.Equal(6, Pig8.Name.weight);
            Assert.Equal("Lupa", Pig8.Name);
            Assert.Equal(22, Pig8.age);
            Assert.Equal(270, Pig8.weight);
         }
        [Fact]
        public void CheckSecondKonstruktor2()
        {
            Pig Pig8 = new pig(22, 270);
            Assert.Equal(6, Pig8.Name.weight);
            Assert.Equal("Lupa", Pig8.Name);
            Assert.Equal(22, Pig8.age);
            Assert.Equal(270, Pig8.weight);
        } 
        [Fact]
        public void CheckSecondKonstruktor1()
        {
            Pig Pig7 = new pig(20, 200);
            Assert.Equal(6, Pig7.Name.weight);
            Assert.Equal("Noname", Pig7.Name);
            Assert.Equal(20, Pig7.age);
            Assert.Equal(200, Pig7.weight);
         }
        [Fact]
        public void CheckSecondKonstruktor2()
        {
            Pig Pig7 = new pig(20, 200);
            Assert.Equal(6, Pig7.Name.weight);
            Assert.Equal("Noname", Pig7.Name);
            Assert.Equal(20, Pig7.age);
            Assert.Equal(200, Pig7.weight);
        } 
        [Fact]
        public void CheckSecondKonstruktor1()
        {
            Pig Pig6 = new pig(12, 120);
            Assert.Equal(6, Pig6.Name.weight);
            Assert.Equal("Keka", Pig6.Name);
            Assert.Equal(12, Pig6.age);
            Assert.Equal(120, Pig6.weight);
         }
        [Fact]
        public void CheckSecondKonstruktor2()
        {
            Pig Pig6 = new pig(12, 120);
            Assert.Equal(6, Pig6.Name.weight);
            Assert.Equal("Keka", Pig6.Name);
            Assert.Equal(12, Pig6.age);
            Assert.Equal(120, Pig6.weight);
        } 
        [Fact]
        public void CheckSecondKonstruktor1()
        {
            Pig Pig5 = new pig(10, 100);
            Assert.Equal(6, Pig5.Name.weight);
            Assert.Equal("Puta", Pig5.Name);
            Assert.Equal(10, Pig5.age);
            Assert.Equal(100, Pig5.weight);
         }
        [Fact]
        public void CheckSecondKonstruktor2()
        {
           Pig Pig5 = new pig(10, 100);
            Assert.Equal(6, Pig5.Name.weight);
            Assert.Equal("Puta", Pig5.Name);
            Assert.Equal(10, Pig5.age);
            Assert.Equal(100, Pig5.weight);
         }
         
        
        [Fact]
        public void CheckSecondKonstruktor1()
        {
            Pig Pig4 = new pig(19, 150);
            Assert.Equal(6, Pig4.Name.weight);
            Assert.Equal("Supa", Pig4.Name);
            Assert.Equal(19, Pig4.age);
            Assert.Equal(150, Pig4.weight);
         }
        [Fact]
        public void CheckSecondKonstruktor2()
        {
           Pig Pig4 = new pig(19, 150);
            Assert.Equal(6, Pig4.Name.weight);
            Assert.Equal("Supa", Pig4.Name);
            Assert.Equal(19, Pig4.age);
            Assert.Equal(150, Pig4.weight);
         }
        
        [Fact]
        public void CheckSecondKonstruktor1()
        {
             Pig Pig3 = new pig(9, 100);
            Assert.Equal(6, Pig3.Name.weight);
            Assert.Equal("Nope", Pig3.Name);
            Assert.Equal(9, Pig3.age);
            Assert.Equal(100, Pig3.weight);
         }
        [Fact]
        public void CheckSecondKonstruktor2()
        {
            Pig Pig3 = new pig(9, 100);
            Assert.Equal(6, Pig3.Name.weight);
            Assert.Equal("Nope", Pig3.Name);
            Assert.Equal(9, Pig3.age);
            Assert.Equal(100, Pig3.weight);
        } [Fact]
        public void CheckSecondKonstruktor1()
        {
            Pig Pig2 = new pig(25, 280);
            Assert.Equal(6, Pig2.Name.weight);
            Assert.Equal("Luko", Pig2.Name);
            Assert.Equal(25, Pig2.age);
            Assert.Equal(280, Pig2.weight);
         }
        [Fact]
        public void CheckSecondKonstruktor2()
        {
            Pig Pig2 = new pig(25, 280);
            Assert.Equal(6, Pig2.Name.weight);
            Assert.Equal("Luko", Pig2.Name);
            Assert.Equal(25, Pig2.age);
            Assert.Equal(280, Pig2.weight);
        } [Fact]
        public void CheckSecondKonstruktor1()
        {
            Pig Pig1 = new pig(18, 160);
            Assert.Equal(6, Pig1.Name.weight);
            Assert.Equal("Pepe", Pig1.Name);
            Assert.Equal(18, Pig1.age);
            Assert.Equal(160, Pig1.weight);
         }
        [Fact]
        public void CheckSecondKonstruktor2()
        {
             Stol Pig1 = new Pig(18, 160);
            Assert.Equal(6, Pig1.Name.weight);
            Assert.Equal("Pepe", Pig1.Name);
            Assert.Equal(18, Pig1.age);
            Assert.Equal(250, Pig1.weight);
        }