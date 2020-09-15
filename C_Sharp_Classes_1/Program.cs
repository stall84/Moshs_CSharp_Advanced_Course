using System;

namespace C_Sharp_Classes_1
{

    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer(1, "John");

            Console.WriteLine($"Customer ID: {customer.Id}");
            Console.WriteLine($"Customer Name: {customer.Name}");
            

        }
    }
}
