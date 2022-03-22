using System;
using static laba3.Canculator;
using static laba3.Services.Task2;
using static laba3.DateService;


namespace laba3
{
    class Program {

        static int Input()  
        {
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
 
                Console.WriteLine("Ошибка ввода введите целое число");
            }
            return x;
        }

        static bool IsNumber(char a)
        {
            if (0 <= a-48 && a-48 <= 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string InputData()
        {
            string data;
            while (true)
            {
                Console.WriteLine("Введите дату, разделяя число, месяц и год ЗАПЯТЫМИ");
                Console.WriteLine("Например 02,09,1994");
                data = Console.ReadLine();
                if (data.Length>=10&&
                    IsNumber(data[0]) && IsNumber(data[1]) && IsNumber(data[3]) && IsNumber(data[4]) &&
                    IsNumber(data[6]) && IsNumber(data[7]) && IsNumber(data[8]) && IsNumber(data[8])
                    && data[2] == ',' && data[5] == ','
                    )
                {
                    string[] numbers = data.Split(new char[] { ',' });
                    //int day, month, year;
                    int.TryParse(numbers[0], out int day);
                    int.TryParse(numbers[1], out int month);
                    int.TryParse(numbers[2], out int year);
                    if (1 <= day && day <= 31 && 1 <= month && month <= 12 && 1 <= year && year <= 9999)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода, попробуйте снова");
                    }




                }
                else
                {
                    Console.WriteLine("Ошибка ввода, попробуйте снова");
                }


            }



            return data;
        }


    
        static void Main(string[] args)
        {
            bool s = true;
            while (s)
            {
                Console.WriteLine("Чтобы выбрать действие введите цифру");
                Console.WriteLine("****************************");
                Console.WriteLine("* 1. 1е задание            *");
                Console.WriteLine("* 2. 2е задание            *");
                Console.WriteLine("* 3. 3е задание            *");
                Console.WriteLine("* 4. выйти из программы    *");
                Console.WriteLine("****************************");


                int num = Input();
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Введите первое целое число");
                        int x = Input();
                        Console.WriteLine("Введите второе целое число");
                        int y = Input();
                        int z = Canculator.Max(x, 2 * y + x) - Canculator.Max(7 * x + 2 * y, y); //z=max(x,2y+x)-max(7x+2y,y)
                        Console.WriteLine(z);
                        break;

                    case 2:
                        Console.WriteLine("Введите число");
                        double w;
                        while (!double.TryParse(Console.ReadLine(), out w))
                        {
                            Console.WriteLine("Ошибка ввода введите целое число");
                        }
                        laba3.Services.Task2.Funtion(w);
                        break;


                    case 3:
                        Console.WriteLine("Какой из методов вы хотите использовать?");
                        Console.WriteLine("###################");
                        Console.WriteLine("# 1. GetDay       #");
                        Console.WriteLine("# 2. GetDaysSpan  #");
                        Console.WriteLine("###################");
                        int d = Input();
                        switch (d)
                        {
                            case 1:
                                DateService.GetDay(InputData());
                                break;
                            case 2:
                                Console.WriteLine("Введите день");
                                int day;
                                while (true)
                                {
                                     day = Input();
                                    if (day <= 0 || day > 31)
                                    {
                                        Console.WriteLine("Ошибка ввода, попробуйте снова");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                Console.WriteLine("Введите месяц");
                                int month;
                                while (true)
                                {
                                    month = Input();
                                    if (month <= 0 || month > 12)
                                    {
                                        Console.WriteLine("Ошибка ввода, попробуйте снова");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                Console.WriteLine("Введите год");
                                int year;
                                while (true)
                                {
                                    year = Input();
                                    if (year <= 0 || year > 9999)
                                    {
                                        Console.WriteLine("Ошибка ввода, попробуйте снова");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                Console.WriteLine("Прошло следующее количество дней: " + DateService.GetDaysSpan(day, month, year));
                                break;
                            default: 
                                Console.WriteLine("Ошибка ввода, попробуйте снова");
                                break;
                        }
                        break;
                    case 4:
                        s = false;
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода, попробуйте снова");
                        break;


                }
            }
        }
    }
}
