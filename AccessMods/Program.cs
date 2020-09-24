using System;

namespace AccessMods
{

    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person(new DateTime(1984, 02, 16));             // Setting birtdate via constructor

            

            Console.WriteLine($"Age of Michael: {person.Age}");
           


            // Below code was used for most-verbose, oldest ways of setting and getting methods from Person. 

            //var person = new Person("Michael");

            //person.SetBirthdate(new DateTime(1984, 2, 16));

            //Console.WriteLine($"Hello {person._name} that was born on {person.GetBirthdate()}");
        }
    }
}
