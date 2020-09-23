using System.Collections.Generic;

namespace C_Sharp_Classes_1
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();  // Another way of initializing the List type automatically 


        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)        // We can ensure that the first parameterless constructor with our Orders initialization always gets
            : this(id)                            // called first by adding a : this() syntax to the other constructors
        {
            this.Name = name;
            
        }

        public void Promote()
        {
            // ...
        }

    }
}
