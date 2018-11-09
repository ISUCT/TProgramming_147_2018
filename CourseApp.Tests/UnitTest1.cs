using System;
using Xunit;
using Matan;


namespace CourseApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
           var res = Program.y(1);
           Assert.Equal(5.0625 , res);
        }
            [Fact]
        public void Test2()
         {
               var res = Program.y(-1);
               Assert.Equal(5.0625, res, 3);
         }
              [Fact]
              public void Test3()
              {
                 var res = Program.y(1.25);
                 Assert.Equal(0.78, res,3);
              }
        [Fact]
        public void Test4()
        {
            var res = Program.y(2.89);
            Assert.Equal(1173.645, res, 3);
        }
                  [Fact]
                   public void Test5()
                 {
                        var res = Program.y(-3.55);
                       Assert.Equal(10417.68, res, 3);
                 }
    }
}
