using System;
using System.Collections.Generic;
using System.Text;

namespace laba4_proga
{
    public class ATS
    {
        private static ATS instance;
        private int numberOfSubscribers; // число абонентов
        private string address; // адрес АТС
        private int payment; // абонетская плата 
        public int CalculationOfPayments()
        {
            return numberOfSubscribers * payment;
        }
        public int CalculationOfPayments(int N) // перегрузка метода
        {
            return N*payment;
        }
        public int GetPayment()
        {
            return payment;
        }
        public void SetPayment(int payment)
        {
            this.payment = payment;
        }
        public string GetAddress()
        {
            return this.address;
        }
        public int GetNumberOfSubscribers()
        {
            return numberOfSubscribers;
        }


        public ATS()
        {
            this.numberOfSubscribers = 0;
            this.payment = 0;
            this.address = "Пустой";
        }
        

        public ATS(int number,string address,int payment)
        {
            this.numberOfSubscribers = number;
            this.address = address;
            this.payment = payment;
        }

        public static ATS getInstatnce(int number, string address, int payment)
        {

            if (instance == null)
            {
                instance = new ATS(number, address, payment);
            }
            return instance;
        }

        public static ATS getInstatnce()
        {
            return instance;
        }

    }


    public  class Rate
    {
        
        public ATS ats;
        public void tariffChange(int payment_m)
        {
            ats.SetPayment(payment_m);
        }

        public Rate(int number, string address, int payment)
        {
            ats = ATS.getInstatnce(number, address, payment);
        }

    }
}
