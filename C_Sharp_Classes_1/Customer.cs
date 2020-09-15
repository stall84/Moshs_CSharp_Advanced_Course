﻿using System.Collections.Generic;

namespace C_Sharp_Classes_1
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Order;


        public Customer()
        {

        }

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
