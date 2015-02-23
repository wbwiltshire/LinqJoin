using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoin
{
    class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public static List<Order> LoadOrders()
        {
            List<Order> orders = new List<Order>()
            {
                new Order() { Id = 1, CustomerId = 1, Description = "Shoes" , Price = 100.00 },
                new Order() { Id = 2, CustomerId = 1, Description = "Car" , Price = 10000.00 },
                new Order() { Id = 3, CustomerId = 2, Description = "Glasses" , Price = 55.00 }
            };

            return orders;
        }
    }
}
