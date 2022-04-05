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
           
            ATS d = new ATS(1, "ул. Мельникайте 7, Минск", 5000);
            int a = d.CalculationOfPayments();
            Assert.Equal(5000, a);

        }

        [Fact]
        public void CalculationOfPayments2_Test1()
        {
            ATS d = new ATS(1, "ул. Мельникайте 7, Минск", 5000);
            int a = d.CalculationOfPayments(5);
            Assert.Equal(25000, a);

         
        }

        [Fact]
        public void GetPayment_Test1()
        {
            ATS d = new ATS(1, "ул. Мельникайте 7, Минск", 5000);
            int a = d.rate.GetPayment();
            Assert.Equal(5000, a);
        }

        [Fact]
        public void GetAddress_Test1()
        {
            ATS d = new ATS(1, "ул. Мельникайте 7, Минск", 5000);
            string f = d.GetAddress();
            Assert.Equal("ул. Мельникайте 7, Минск", f);
        }

        [Fact]
        public void GetNumberOfSubscribers_Test1()
        {
            ATS d = new ATS(1, "ул. Мельникайте 7, Минск", 5000);
            int a = d.GetNumberOfSubscribers();
            Assert.Equal(1, a);
        }
    }

 
}
