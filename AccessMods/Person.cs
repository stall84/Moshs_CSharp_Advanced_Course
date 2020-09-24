using System;

namespace AccessMods
{
    class Person
    {
        private DateTime _birthdate;

        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }

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
