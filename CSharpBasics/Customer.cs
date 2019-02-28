using System.Collections.Generic;


namespace CSharpBasics
{
    class Customer
    {
        public string Name;
        public int id;
        public List<Order> OrderList;

        public Customer()
        {
            OrderList = new List<Order>();
        }

        public Customer(string name)
            :this()
        {
            this.Name = name;
        }
        public Customer(string name,int id)
            :this(name)
        {
            //this.id = id;
            this.Name = name;

        }
    }

    class Cust
    {
        string str1;
        public Cust(string name)
        {
            this.str1 = name;
        }

    }
}



