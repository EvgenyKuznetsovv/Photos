using System;
using Xunit;
using static task2.Program;

namespace task2.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string s = "Да";
            Assert.Equal(s, message(15,15));   
        }
        [Fact]
        public void Test2()
        {
            string s = "Нет";
            Assert.Equal(s, message(55, 15));
        }
        [Fact]
        public void Test3()
        {
            string s = "На границе";
            Assert.Equal(s, message(50, 15));
        }

        [Fact]
        public void Test4()
        {
            string s = "На границе";
            Assert.Equal(s, message(50, 25));
        }
        [Fact]
        public void Test5()
        {
            string s = "На границе";
            Assert.Equal(s, message(-50, -15));
        }
        [Fact]
        public void Test6()
        {
            string s = "Да";
            Assert.Equal(s, message(-15, 15));
        }
        [Fact]
        public void Test7()
        {
            string s = "Нет";
            Assert.Equal(s, message(-55, 15));
        }




















    }
}
