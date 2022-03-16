using System;

namespace task1
{

    public class Program
    {

       public static string message(int first, int second)
        {
            if (first > second)
            {
                return "Первая цифра больше";
            }
            if (first < second)
            {
                return "Первая цифра меньше";
            }
            if (first == second)
            {
                return "Первая цифра равна последней";
            }

            return "Что-то пошло не так";
        }

        static void Main(string[] args)
        {
            bool s = true;
            while (s)
            {

                
                Console.WriteLine("******************************************");
                Console.WriteLine("* Введите число, чтобы выбрать действие: *");
                Console.WriteLine("* 1.Продолжить                           *");
                Console.WriteLine("* 2.Закончить                            *");
                Console.WriteLine("******************************************");
                int a;
                while (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Что-то пошло не так, введите целое число");
                }


                switch (a)
                {
                    case 1:
                        int number;
                        Console.WriteLine("Введите трехназное число");
                        while (!int.TryParse(Console.ReadLine(), out number) || number < 100 || number > 999)
                        {
                            Console.WriteLine("Что-то пошло не так, введите целое трехначное число");
                        }

                        int first = number / 100;
                        int second = number % 10;
                       
                        Console.WriteLine(message(first,second));
                        break;

                    case 2:
                        s = false;
                        break;

                    default:
                        Console.WriteLine("Вы ввели неверное число, попробуйте еще раз");
                        break;

                }


            }
        }
    }
}

