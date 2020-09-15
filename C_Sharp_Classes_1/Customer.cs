using System.Collections.Generic;

namespace C_Sharp_Classes_1
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;


        public Customer()
        {
            Orders = new List<Order>();         // A List must be initialized by constructor to avoid null ref exception
        }

        public Customer(int id)                 // We can ensure that the first parameterless constructor with our Orders initialization always gets
            : this()                            // called first by adding a : this() syntax to the other constructors
        {
            
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
           
            this.Name = name;
        }

    }
}
