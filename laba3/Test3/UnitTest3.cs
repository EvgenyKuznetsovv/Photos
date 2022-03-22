using System;
using Xunit;
using static laba3.DateService;

namespace Test3
{
    public class UnitTest3
    {
        [Fact]
        public void Test1()
        {
            int s = laba3.DateService.GetDaysSpan(15,12,2045);
            Assert.Equal(8668,s);
        }


        [Fact]
        public void Test2()
        {
            int s = laba3.DateService.GetDaysSpan(3, 9, 2011);
            Assert.Equal(3853, s);
        }

        [Fact]
        public void Test3()
        {
            int s = laba3.DateService.GetDaysSpan(6, 6, 6);
            Assert.Equal(736253, s);
        }

        [Fact]
        public void Test4()
        {
            int s = laba3.DateService.GetDaysSpan(9, 9, 2222);
            Assert.Equal(73218, s);
        }
    }
}
