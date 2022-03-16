using System;

namespace task2
{
    public class Program
    {
        public static string  message(double x,double y)
        {
            bool s = true;
            if (Math.Abs(x) < 50 && Math.Abs(y) < 25)
            {
                
                s = false;
                return "Да";
            }
            if (Math.Abs(x) > 50 || Math.Abs(y) > 25)
            {
                s = false;
                return "Нет";
            }
            if (s)
            {
                return "На границе";
            }
            return "Что-то пошло не так";
        }

        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
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
                        Console.WriteLine("Введите координату х точки");
                        double x;
                        while (!double.TryParse(Console.ReadLine(), out x))
                        {
                            Console.WriteLine("Что-то пошло не так, попробуйте снова");
                        }

                        Console.WriteLine("Введите координату у точки");
                        double y;
                        while (!double.TryParse(Console.ReadLine(), out y))
                        {
                            Console.WriteLine("Что-то пошло не так, попробуйте снова");
                        }

                        //Console.WriteLine(x + " " + y);

                        Console.WriteLine(message(x, y));
                        break;
                    case 2:

                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Вы ввели неверное число, попробуйте еще раз");
                        break;
                }

            }
        }
    }
}
