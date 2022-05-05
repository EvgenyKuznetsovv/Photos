using System;
using Xunit;
using laba7_proga;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Complex num1 = new Complex();
            num1.SetImaginary(24);
            num1.SetValid(20);
            Assert.Equal(20, num1.GetValid());
            Assert.Equal(24, num1.GetImaginary());
        }

        [Fact]
        public void Test2()
        {
            Complex num1 = new Complex(10, 12);
            Complex num2 = new Complex(10, 12);
            Complex num3 = new Complex(num1 + num2);
            string info = num3.ToString();
            Assert.Equal("20+24i", num3.ToString());
           
        }

        [Fact]
        public void Test3()
        {
            Complex num1 = new Complex(78, 15);
            Complex num2 = new Complex(10, 12);
            Complex num3 = new Complex(num1 - num2);
            string info = num3.ToString();
            Assert.Equal("68+3i", num3.ToString());
        }

        [Fact]
        public void Test4()
        {
            Complex num1 = new Complex(78, 15);
            Complex num2 = new Complex(10, 12);
            Complex num3 = new Complex(num1 * num2);
            string info = num3.ToString();
            Assert.Equal("600+1086i", num3.ToString());
        }

        [Fact]
        public void Test5()
        {
            Complex num1 = new Complex(78, 15);
            Complex num2 = new Complex(10, 12);
            Complex num3 = new Complex(num1 / num2);
            string info = num3.ToString();
            Assert.Equal("3,9344262295081966+-3,221311475409836i", num3.ToString());
        }


        [Fact]
        public void Test6()
        {
            Complex num1 = new Complex(78, 15);
            num1++;

            Assert.Equal(79,num1.GetValid());

        }
        [Fact]
        public void Test7()
        {
            Complex num1 = new Complex(78, 15);
            num1--;

            Assert.Equal(77, num1.GetValid());
        }

        [Fact]
        public void Test8()
        {
            Complex num1 = new Complex(78, 15);
            Complex num2 = new Complex(num1 - 8);

            Assert.Equal(70, num2.GetValid());

        }

        [Fact]
        public void Test9()
        {
            Complex num1 = new Complex(78, 15);
            Complex num2 = new Complex(num1 + 12);

            Assert.Equal(90, num2.GetValid());
        }

        










    }
}
