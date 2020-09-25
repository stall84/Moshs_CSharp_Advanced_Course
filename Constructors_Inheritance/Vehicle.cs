using System;
namespace Constructors_Inheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being initialized - Reg Num: {0}", registrationNumber);
        }
    }
}
