using System;

namespace Abstract_Classes
{
    // Using ABSTRACT declaration instead of VIRTUAL demands/requires the derived class to override the member/method/whatever
    // With VIRTUAL: The derived class can chose to override it or not.. ABSTRACT has NO implementation in the base class, it's simply a line
    // declaration like "public abstract void Something();" .. The implementation MUST be handled by the deriving class. This 'forces' more control
    // of the developer for later implementations of the code. Also. The base class containing the Abstract methods must also be declared as Abstract.
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a damn circle");
        }
    }
}
