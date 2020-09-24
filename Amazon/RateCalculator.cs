using System;
namespace Amazon
{
    internal class RateCalculator
    {
        // Even though this class library (Amazon) is linked/referenced by our Inheritance/AccessMods project
        // Setting this accessmod to 'internal' will only allow it to be accessed from within this
        // assembly. So it's not accessible from the outside project (even though it's duly referenced/linked)
        // This kind of insures that no external code can be broken if you make a change to an internal class
        public int Calculate()
        {
            return 0;
        }
    }
}
