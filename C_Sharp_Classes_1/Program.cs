using System;

namespace C_Sharp_Classes_1
{

    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer();

            customer.Name = "John";
            customer.Id = 1;


            var order = new Order();
            customer.Orders.Add(order);         // Without providing initialization of list in contsructor, this will throw a Null Ref Exception

            Console.WriteLine($"Customer ID: {customer.Id}");
            Console.WriteLine($"Customer Name: {customer.Name}");
            

        }
    }
}
