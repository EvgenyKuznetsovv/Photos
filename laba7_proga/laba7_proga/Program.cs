using System;


namespace laba7_proga
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex num1 = new Complex();
            num1.SetImaginary(24);
            num1.SetValid(20);
            Complex num2 = new Complex(10, 12);
            Complex num3 = new Complex(num1 + num2);
            Complex num4 = new Complex(num1 - num2);
            Complex num5 = new Complex(num1 * num2);
            Complex num6 = new Complex(num2 / num1);
            if (num5 > num6)
            {
                Console.WriteLine("Работает");
            }
            if (num6 < num5)
            {
                Console.WriteLine("Работает");
            }

            num1++;
            num2--;
            Console.WriteLine(num1.ToString());
            Console.WriteLine(num2.ToString());
            Console.WriteLine(num3.ToString());
            Console.WriteLine(num4.ToString());
            Console.WriteLine(num5.ToString());
            Console.WriteLine(num6.ToString());



        }
    }
}
