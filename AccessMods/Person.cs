using System;

namespace AccessMods

{
    class Person

        // Evolution of Birthdate get/set methods shown below with furthest down = oldest/most verbose 
    {
        public DateTime Birthdate { get; private set; }     // Takes it even further. Allow the C# compiler to create the private
                                                            // The private accessor before the set means the field can ONLY be set at initialization via Constructor
                                                            // readonly field for you, also handling the actual getting and setting codeblock logic

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;                           // Allows setting the birtday only once at object initialization
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }

        }
            //private DateTime _birthdate;

            //public DateTime Birthdate
            //{
            //    get { return _birthdate; }      // Simply returning the private field .. just like the lengthy GetBirthdate method below commented out
            //    set { _birthdate = value; }     // Using value keyword to get whatever will be on the right side of the assignment at runtime
            //}

            //public string _name;

            //public Person(string name)
            //{
            //    this._name = name;                                // Converting all of this commented-out block to simplified
            //}                                                     // Getter/Setter Properties (foregoing the name prop/ctor)

            //public void SetBirthdate(DateTime birthdate)
            //{
            //    this._birthdate = birthdate;
            //}

            //public DateTime GetBirthdate()
            //{
            //    return _birthdate;
            //}
        }
}
