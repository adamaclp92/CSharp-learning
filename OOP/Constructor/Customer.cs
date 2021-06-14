using System.Collections.Generic;

namespace Constructor
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this()
        {
            this.Id = id;
            this.Name = name;
        }

        public Customer()
        {
            Orders = new List<Order>();
        }
    }
}
