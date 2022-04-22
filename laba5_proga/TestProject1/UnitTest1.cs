using System;
using Xunit;
using laba5_proga;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ATS ats = new ATS();
            ats.AddClient("Evgeny", ClientType.VIP);
            Rate rate1 = new Rate(500, "Poland");
            ats.AddRate(rate1);
            ats.AddRate(1000, "USA");
            ats.AddRate(777, "UK");
            Call call1 = new Call(rate1, 5);
            ats.CallLogging(0, call1);
            ats.CallLogging(0, 20, ats.GetRates()[1]);
            Assert.Equal(22500, ats.SearchNameAndGetPrice("Evgeny"));


        }


        [Fact]
        public void Test2()
        {
            ATS ats = new ATS();
            ats.AddClient("Evgeny", ClientType.VIP);
            Rate rate1 = new Rate(5000, "Poland");
            ats.AddRate(rate1);
            ats.AddRate(10000, "USA");
            ats.AddRate(777, "UK");
            Call call1 = new Call(rate1, 5);
            ats.CallLogging(0, call1);
            ats.CallLogging(0, 20, ats.GetRates()[1]);
            ats.CallLogging("Evgeny", 10, ats.GetRates()[2]);
            Assert.Equal(232770, ats.SearchNameAndGetPrice("Evgeny"));
        }


        [Fact]
        public void Test3()
        {
            ATS ats = new ATS();
            ats.AddClient("Evgeny", ClientType.VIP);
            Rate rate1 = new Rate(5860, "Poland");
            ats.AddRate(rate1);
            ats.AddRate(19870, "USA");
            ats.AddRate(7877, "UK");
            Call call1 = new Call(rate1, 5);
            ats.CallLogging(0, call1);
            ats.CallLogging(0, 20, ats.GetRates()[1]);
            Assert.Equal(426700, ats.SearchNameAndGetPrice("Evgeny"));
        }

        [Fact]
        public void Test4()
        {
            ATS ats = new ATS();
            ats.AddClient("Evgeny", ClientType.VIP);
            Rate rate1 = new Rate(500, "Poland");
            ats.AddRate(rate1);
            ats.AddRate(1000, "USA");
            ats.AddRate(777, "UK");
            Call call1 = new Call(rate1, 5);
            ats.CallLogging(0, call1);
            ats.CallLogging(0, 20, ats.GetRates()[1]);
            ats.AddClient("Alex", ClientType.Standard);
            ats.CallLogging("Alex", 45, ats.GetRates()[2]);
            int sumClient1 = ats.SearchNameAndGetPrice("Evgeny");
            long sumAll = ats.TotalCoastOfATS();
            Assert.Equal(57465, sumAll);
        }

        [Fact]
        public void Test5()
        {
            ATS ats = new ATS();
            ats.AddClient("Evgeny", ClientType.VIP);
            Rate rate1 = new Rate(500, "Poland");
            ats.AddRate(rate1);
            ats.AddRate(1070, "USA");
            ats.AddRate(8981, "UK");
            Call call1 = new Call(rate1, 5);
            ats.CallLogging(0, call1);
            ats.CallLogging(0, 840, ats.GetRates()[1]);
            ats.AddClient("Alex", ClientType.Standard);
            ats.CallLogging("Alex", 455, ats.GetRates()[2]);
            int sumClient1 = ats.SearchNameAndGetPrice("Evgeny");
            long sumAll = ats.TotalCoastOfATS();
            Assert.Equal(4987655, sumAll);
        }

        [Fact]
        public void Test6()
        {
            ATS ats = new ATS();
            ats.AddClient("Evgeny", ClientType.VIP);
            Rate rate1 = new Rate(500, "Poland");
            ats.AddRate(rate1);
            ats.AddRate(10, "USA");
            ats.AddRate(81, "UK");
            Call call1 = new Call(rate1, 5);
            ats.CallLogging(0, call1);
            ats.CallLogging(0, 40, ats.GetRates()[1]);
            ats.AddClient("Alex", ClientType.Standard);
            ats.CallLogging("Alex", 4, ats.GetRates()[2]);
            int sumClient1 = ats.SearchNameAndGetPrice("Evgeny");
            long sumAll = ats.TotalCoastOfATS();
            Assert.Equal(3224, sumAll);
        }








    }
}
