using System;

namespace Constructors_Inheritance
{
    // NOTES:  Base class constructors are always executed FIRST.
    // Base class constructors are also not inherited meaning in a derived class
    // you must re-define your constructors.
    // -->> OR use :base keyword to pull in the constructor from the base class

    // Example:
    //public class Vehicle
    //{
    //    private readonly string _registrationNumber;

    //    public Vehicle(string registrationNumber)
    //    {
    //        _registrationNumber = registrationNumber;
    //    }
    //}

    //public class Car : Vehicle
    //{
    //    public Car(string registrationNumber)
    //        : base(registrationNumber)          // Using the ' : base ' syntax we pull in the otherwise private readonly field from Vehicle base class
    //    {
    //        //... Anything specific to the initialization of Car class
    //    }
    //}

    class Program
    {


        static void Main(string[] args)
        {
            var car = new Car("ZDA83920370DHA3903");
        }
    }
}
