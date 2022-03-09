using System;

namespace _153502_Kuznetsov
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the first number");
            string buf;
            buf = Console.ReadLine();
            double a = Convert.ToDouble(buf);

            Console.WriteLine("Enter the second number");
            buf = Console.ReadLine();
            double b = Convert.ToDouble(buf);
            
            double c = a / b;
            Console.WriteLine("first number / second number = " + c);
        }
    }
}
