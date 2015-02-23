using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoin
{
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static List<Customer> LoadCustomers()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer() {
                    Id = 1,
                    FirstName = "George",
                    LastName = "Washington"
                },
                new Customer() { 
                    Id = 2,
                    FirstName = "Ben",
                    LastName = "Franklin"
                }
            };

            return customers;
        }
    }

}
