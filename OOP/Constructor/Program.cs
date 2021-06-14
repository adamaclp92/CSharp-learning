using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "John");

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            Console.ReadKey();
        }
    }
}
