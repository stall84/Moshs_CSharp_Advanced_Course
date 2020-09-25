using System;
namespace Constructors_Inheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)                      // Here we're inheriting the Vehicles constructor
                                                            // The input parameter must be specified just like in the
                                                            // base class
        {
            Console.WriteLine("Car is being initialized: Reg Num: {0}", registrationNumber);
        }
    }
}
