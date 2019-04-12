using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            DateTime res = new DateTime(2019, 04, 07);
            DateTime bd = new DateTime(1999, 11, 23);
            string d = "19 4 15";
            Assert.Equal(d, Data(res, bd));
        }
    }
}
