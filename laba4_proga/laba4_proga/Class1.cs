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
        
        public Rate rate;
        public int CalculationOfPayments()
        {
            return numberOfSubscribers * rate.GetPayment();
        }
        public int CalculationOfPayments(int N) // перегрузка метода
        {
            return N*rate.GetPayment();
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
            //this.payment = 0;
            this.address = "Пустой";
            this.rate = new Rate(0);
        }
        

        public ATS(int number,string address,int payment)
        {
            this.numberOfSubscribers = number;
            this.address = address;
            rate = new Rate(payment);
            //this.payment = payment;
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

        public void tariffChange(int payment_m)
        {
            rate.SetPayment(payment_m);
        }

        





    }


    public  class Rate
    {

       
        
        private int payment; // абонентская плата 
        

        public int GetPayment()
        {
            return payment;
        }
        public void SetPayment(int payment)
        {
            this.payment = payment;
        }

        

        public Rate(int payment)
        {
           
            this.payment = payment;
        }

    }
}
