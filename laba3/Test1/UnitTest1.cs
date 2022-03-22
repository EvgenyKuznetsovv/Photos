using System;
using Xunit;
using static laba3.Canculator;


namespace Test1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
           int s = laba3.Canculator.Max(12, 12);
           Assert.Equal(12,s);
        }

        [Fact]
        public void Test2()
        {
            int s = laba3.Canculator.Max(25, 12);
            Assert.Equal(25, s);
        }

        [Fact]
        public void Test3()
        {
            int s = laba3.Canculator.Max(25, 40);
            Assert.Equal(40, s);
        }
    }  
}
