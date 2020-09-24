using System;

namespace AccessMods
{
    class Person
    {
        private DateTime _birthdate;
        public string _name;

        public Person(string name)
        {
            this._name = name;
        }

        public void SetBirthdate(DateTime birthdate)
        {
            this._birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Michael");

            person.SetBirthdate(new DateTime(1984, 2, 16));

            Console.WriteLine($"Hello {person._name} that was born on {person.GetBirthdate()}");
        }
    }
}
