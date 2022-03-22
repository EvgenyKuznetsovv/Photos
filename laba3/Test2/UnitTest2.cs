using System;
using Xunit;
using static laba3.Services.Task2;

namespace Test2
{
    public class UnitTest2
    {
        [Fact]
        public void Test1()
        {
            double s = laba3.Services.Task2.Funtion(8);
            Assert.Equal(0.05431704423541489, s);
        }

        [Fact]
        public void Test2()
        {
            double s = laba3.Services.Task2.Funtion(12.5);
            Assert.Equal(-0.3738078186849495, s);
        }

        [Fact]
        public void Test3()
        {
            double s = laba3.Services.Task2.Funtion(78);
            Assert.Equal(-1.6320886767332554, s);
        }

        [Fact]
        public void Test4()
        {
            double s = laba3.Services.Task2.Funtion(100);
            Assert.Equal(-1.7760474150888808, s); //10686474581527,959
        }

        [Fact]
        public void Test5()
        {
            double s = laba3.Services.Task2.Funtion(-5);
            Assert.Equal(10686474581527.959, s);
        }
    }
}
