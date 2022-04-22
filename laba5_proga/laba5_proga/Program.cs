using System;
using System.Collections.Generic;

namespace laba5_proga
{

    public class ATS
    {
        private List<Client> clients; // список клиетов 
        private List<Rate> rates; // спиоск тарифов

        public ATS()
        {
            clients = new List<Client>();
            rates = new List<Rate>();
        }

        public List<Rate> GetRates()
        {
            return rates;
        }

        public string GetInfoRates()
        {
            string s = "";
            for(int i = 0; i < rates.Count; i++)
            {
                s += rates[i].GetInfo();
            }
            return s;
        }

        public string GetInfoClients()
        {
            string s = "";
            for (int i = 0; i < clients.Count; i++)
            {
                s += clients[i].GetInfo();
            }
            return s;
        }

        public long TotalCoastOfATS()
        {
            long sum = 0;
            for(int i = 0; i < clients.Count; i++)
            {
                sum += clients[i].CostOfCalls();
            }
            return sum;
        }


        public void AddRate(int payment, string name)
        {
            rates.Add(new Rate(payment, name));
        }

        public void AddRate(Rate rate)
        {
            rates.Add(rate);
        }

        public void AddClient(string name,ClientType type)
        {
            Client client = new Client(name, type);
            clients.Add(client);
        }

        public void CallLogging(int index,Call call)
        {
            clients[index].AddCall(call);
        }

        public void CallLogging(int index, int min , Rate rate)
        {
            clients[index].AddCall(rate,min);
        }

        public void CallLogging(string name, int min, Rate rate)
        {
            for(int i = 0; i < clients.Count; i++)
            {
                if (clients[i].GetName() == name)
                {
                    clients[i].AddCall(new Call(rate, min));
                }
            }
        }

        public int SearchNameAndGetPrice(string name) 
        {
            for(int i = 0; i < clients.Count; i++)
            {
                if (clients[i].GetName() == name)
                {
                    return clients[i].CostOfCalls();
                }
            }
            return -1; // если не находит с таким именем то возвращает -1
        }
    }

    public class Rate
    {
        private int payment; // абонентская плата 
        private string title; // название тарифа
        public int GetPayment()
        {
            return payment;
        }
        public void SetPayment(int payment)
        {
            this.payment = payment;
        }
        public string GetTitle()
        {
            return this.title;
        }
        public void SetTitle(string name)
        {
            this.title = name;
        }

        public Rate(int payment, string name)
        {
            this.payment = payment;
            title = name;
        }

        public string GetInfo()
        {
            string info = "";
            info += "*****************\n";
            info += "payment: " + payment + "\n";
            info += "title: " + title + "\n";
            info += "*****************\n";
            return info;
        }


    }


    public enum ClientType
    {
        VIP,
        Standard
    }


    public class Client
    {
        private List<Call> calls = new List<Call>(); // список звонков клиента 
        private string name; // имя клиента
        ClientType type;
        public Client()
        {
            calls = new List<Call>();
            type = ClientType.Standard;
            name = "NO NAME";
        }

        public string GetInfo()
        {
            string s = "";
            s += "*****************\n";
            s += "name: " + this.name + "\n";
            s += "type: " + this.type + "\n";
            s += "cost of all calls: " + this.CostOfCalls() + "\n";
            s += "*****************\n";
            return s;
        }

        public Client(string name, ClientType type)
        {
            this.type = type;
            this.name = name;
        }

        public Client(List<Call> calls, string name, ClientType type)
        {
            this.type = type;
            this.name = name;
            this.calls = calls;
        }

        public void AddCall(Call call)
        {
            calls.Add(call);
        }

        public void AddCall(Rate rate,int min)
        {
            calls.Add(new Call(rate, min));
        }

        public string GetName()
        {
            return this.name;
        }


        public int CostOfCalls()
        {
            int sum = 0;
            for(int i = 0; i < calls.Count; i++)
            {
                sum += calls[i].GetPrice();
            }
            return sum;
        }
    }


    public class Call
    {
        private Rate rate; // тариф
        private int min; // сколько минут разговаривал
        public int GetPrice()
        {
            return rate.GetPayment() * min;
        }
        public Call(Rate rate,int min)
        {
            this.rate = rate;
            this.min = min;
        }

    }





    class Program
    {
        static void Main(string[] args)
        {
            ATS ats = new ATS();
            ats.AddClient("Evgeny", ClientType.VIP);
            Rate rate1 = new Rate(500, "Poland");
            ats.AddRate(rate1);
            ats.AddRate(1000, "USA");
            ats.AddRate(777, "UK");
            Call call1 = new Call(rate1, 5);
            ats.CallLogging(0, call1);
            ats.CallLogging(0, 20, ats.GetRates()[1]);
            ats.AddClient("Alex", ClientType.Standard);
            ats.CallLogging("Alex", 45, ats.GetRates()[2]);
            int sumClient1 = ats.SearchNameAndGetPrice("Evgeny");
            long sumAll = ats.TotalCoastOfATS();
            Console.WriteLine(ats.GetInfoClients());
            Console.WriteLine("\n\n\n");
            Console.WriteLine(ats.GetInfoRates());
            Console.WriteLine("\n\n\n");
            Console.WriteLine(sumClient1);
            Console.WriteLine("\n\n\n");
            Console.WriteLine(sumAll);

        }
    }
}
