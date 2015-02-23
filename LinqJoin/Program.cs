using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LinqJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CustomerOrder> typedCustomerOrders;
            List<Customer> customers = Customer.LoadCustomers();
            List<Order> orders = Order.LoadOrders();

            Console.WriteLine("Customers:");
            foreach (Customer c in customers)
                Console.WriteLine(String.Format("\t{0}|{1}", c.FirstName, c.LastName));

            Console.WriteLine();
            Console.WriteLine("Customer Orders(typed1):");
            typedCustomerOrders = (List<CustomerOrder>) orders.Join(customers, o => o.CustomerId,
                c => c.Id, (o, c) => new CustomerOrder() { Id = o.Id, FirstName = c.FirstName, LastName = c.LastName, Price = o.Price }).ToList();
            foreach (CustomerOrder co in typedCustomerOrders)
                Console.WriteLine(String.Format("\t{0}|{1}|{2}|{3}", co.Id, co.FirstName, co.LastName, co.Price));

            Console.WriteLine();
            Console.WriteLine("Customer Orders(typed2):");
            typedCustomerOrders = new List<CustomerOrder>();
            foreach (var co in orders.Join(customers, o => o.CustomerId, c => c.Id, (o, c) => new { o.Id, c.FirstName, c.LastName, o.Price }))
            {
                CustomerOrder customerOrder = new CustomerOrder
                {
                    Id = co.Id,
                    FirstName = co.FirstName,
                    LastName = co.LastName,
                    Price = co.Price
                };
                typedCustomerOrders.Add(customerOrder);
            }
            foreach (CustomerOrder co in typedCustomerOrders)
                Console.WriteLine(String.Format("\t{0}|{1}|{2}|{3}", co.Id, co.FirstName, co.LastName, co.Price));

            Console.WriteLine();
            Console.WriteLine("Press <enter> to end.");
            Console.ReadLine();
        }
    }
}
