using System.IO;

namespace Abstract_Classes
{
    // Using ABSTRACT declaration instead of VIRTUAL demands/requires the derived class to override the member/method/whatever
    // With VIRTUAL: The derived class can chose to override it or not.. ABSTRACT has NO implementation in the base class, it's simply a line
    // declaration like "public abstract void Something();" .. The implementation MUST be handled by the deriving class. This 'forces' more control
    // of the developer for later implementations of the code. Also. The base class containing the Abstract methods must also be declared as Abstract.
    class Program
    {   

        static void Main(string[] args)
        {

            //var shape = new Shape();                  // Abstract classes cannot be instantiated. Which should make sense because they're abstract in nature
            var circle = new Circle();
            var rectangle = new Rectangle();

            circle.Draw();
            rectangle.Draw();
            rectangle.Copy();


        }
    }
}
