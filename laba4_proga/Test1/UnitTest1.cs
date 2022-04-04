using System;
using Xunit;
using laba4_proga;

namespace Test1
{
    public class ATS_Test1
    {
       
        [Fact]
        public void CalculationOfPayments1_Test1()
        {
            Rate d = new Rate(1, "ул. Мельникайте 7, Минск", 5000);
            int a = d.ats.CalculationOfPayments();
            Assert.Equal(5000, a);   
        }

        [Fact]
        public void CalculationOfPayments2_Test1()
        {
            Rate d = new Rate(1, "ул. Мельникайте 7, Минск", 5000);
            int a = d.ats.CalculationOfPayments(5);
            Assert.Equal(25000, a);
        }

        [Fact]
        public void GetPayment_Test1()
        {
            Rate d = new Rate(1, "ул. Мельникайте 7, Минск", 5000);
            int a = d.ats.GetPayment();
            Assert.Equal(5000, a);
        }

        [Fact]
        public void GetAddress_Test1()
        {
            Rate d = new Rate(1, "ул. Мельникайте 7, Минск", 5000);
            string f = d.ats.GetAddress();
            Assert.Equal("ул. Мельникайте 7, Минск", f);
        }

        [Fact]
        public void GetNumberOfSubscribers_Test1()
        {
            Rate d = new Rate(1, "ул. Мельникайте 7, Минск", 5000);
            int a = d.ats.GetNumberOfSubscribers();
            Assert.Equal(1, a);
        }
    }

    public class ATS_Test2
    {
        [Fact]
        public void CalculationOfPayments1_Test2()
        {
            Rate ds = new Rate(1, "ул. Мельникайте 7, Минск", 5000);
            int a = ds.ats.CalculationOfPayments();
            Assert.Equal(5000, a);
        }

        [Fact]
        public void CalculationOfPayments2_Test2()
        {
            Rate d = new Rate(1, "ул. Мельникайте 7, Минск", 5000);
            int a = d.ats.CalculationOfPayments(5000);
            Assert.Equal(25000000, a);
        }
    }

    public class ATS_Test3
    {
        [Fact]
        public void CalculationOfPayments1_Test3()
        {
            Rate d = new Rate(1, "ул. Мельникайте 7, Минск", 5000);
            int a = d.ats.CalculationOfPayments();
            Assert.Equal(5000, a);
            int b = d.ats.CalculationOfPayments(10);
            Assert.Equal(50000,b);

        }

        /*[Fact]
        public void tariffChange_Test1()
        {
            Rate d = new Rate(1, "ул. Мельникайте 7, Минск", 5000);
            d.tariffChange(6969);
            int s = d.ats.GetPayment();
            Assert.Equal(6969, s);
        }

        [Fact]
        public void SetPayment_Test1()
        {
            Rate d = new Rate(1, "ул. Мельникайте 7, Минск", 5000);
            d.ats.SetPayment(10);
            int a = d.ats.GetPayment();
            Assert.Equal(10, a);
        }*/



    }

}
