using System;


namespace laba6_proga
{
    public abstract class Technics
    {
        protected string Name;
        protected int Price; 
        public Technics()
        {
            Name = "Техника";
            Price = 0;
            Console.WriteLine("Вызов конструктора родительского класса");
        }
        public Technics(string name, int price)
        {
            Name = name;
            Price = price;
            Console.WriteLine("Вызов конструктора родительского класса");
        }
        public abstract void WhoAmI(); // абстрактный метод
        public int Sum(int a,int b)
        {
            return a + b;
        }
        public int Minus(int a,int b)
        {
            return a - b;
        }
        public int GetPrice()
        {
            return Price;
        }
        public string GetName()
        {
            return Name;
        }
        public void ChageInfo(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public void Shutdown()
        {
            Console.WriteLine("Устройство выключенно");

        }
        public void Update()
        {
            Console.WriteLine("Идет обновление");
        }
        public virtual void  GetInfo() // виртульный 
        {
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Стоимость: " + Price);
        }


    }

    public class Computer : Technics
    {
        private string Keyboard;
        private string Monitor;
        public Computer(string name,int price,string key,string mon) : base(name, price)
        {
            Keyboard = key;
            Monitor = mon;
        }
        public override void WhoAmI()
        {
            Console.WriteLine("Я Компьютер");
        }
        public int GetPrice(int N) // перегруженный метод
        {
            return Price * N;
        }
        public new void Update() // скрываем метод родительского класса 
        {
            base.Update(); // вызываем метод родительского класса
            Console.WriteLine("Не выключайте компьютер");
        }
        public void ChageInfo(string name, int price,string key, string mon) // перегрузка
        {
            ChageInfo(name, price);
            Keyboard = key;
            Monitor = mon;
        }

        public override void GetInfo() // переопределение 
        {
            base.GetInfo();
            Console.WriteLine("Клавиатура: "+ Keyboard);
            Console.WriteLine("Монитор: "+ Monitor);

        }




    }

    public sealed class Tablet : Technics // класс, закрытый для наследования.
    {
        public Tablet(string name, int price) : base(name, price) { }
        public override void WhoAmI()
        {
            Console.WriteLine("Я Планшет");
        }
        public void recharge()
        {
            Console.WriteLine("Идет зарядка");
        }

    }





    class Program
    {
        static void Main(string[] args)
        {

            Computer comp = new Computer("Комп",2500, "Redragon Lakshmi","Benq");
            Console.WriteLine(comp.GetPrice(56));
            Console.WriteLine(comp.GetPrice());
            Console.WriteLine(comp.GetName());
            Console.WriteLine(comp.Minus(8,6));
            Console.WriteLine(comp.Sum(568,65));
            comp.Update();
            comp.WhoAmI();
            comp.Shutdown();
            comp.ChageInfo("ASUS", 3200);
            comp.GetInfo();
            Tablet tab = new Tablet("Sfyufufgy", 5646854);
            tab.ChageInfo("Sumsung", 2100);
            tab.GetInfo();
            tab.Shutdown();
            tab.Update();
            tab.WhoAmI();














        }
    }
}
