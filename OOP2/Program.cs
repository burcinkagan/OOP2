using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek müşteri
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Burçin";
            customer1.Surname = "Kağan";
            customer1.TcNumber = "12345678900";

            //Tüzel müşteri
            Coorporate customer2 = new Coorporate();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "123456789546";

            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();
            //Customer class'ı hem individual'in hem de Coorporative'in referans numarasını tutar.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
