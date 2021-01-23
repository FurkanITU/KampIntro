using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 1;
            customer1.CustomerNum = "12345";
            customer1.Name = "Engin";
            customer1.Surname = "Demiroğ";
            customer1.TcNo = "12345678910";

            //kodlama.io
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNum = "53456";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxesNo = "1234567890";


            Musteri customer3 = new RealCustomer();
            Musteri customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
