using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LinqStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //basic();

            List<Customer> clist = new List<Customer>();
            clist.Add(new Customer("shanghai", 11,"Alice"));
            clist.Add(new Customer("shanghai", 22,"Bob"));
            clist.Add(new Customer("nyc", 21,"Carter"));
            clist.Add(new Customer("tianjin", 11,"Deniel"));
            clist.Add(new Customer("nyc", 33,"Ella"));
            // var queryCustomerByCity = from customer in clist group customer by customer.City;

            /*foreach (var customerGroup in queryCustomerByCity) {
                Console.WriteLine(customerGroup.Key);
                foreach (Customer customer in customerGroup) {
                    Console.WriteLine("{0},{1}", customer.City, customer.Age);
                }

            }*/

            //var queryCustomerByCity = from customer in clist group customer by customer.City into custgroup where custgroup.Count() >= 2 select custgroup;
            //foreach (var customerGroup in queryCustomerByCity)
            //{
            //    Console.WriteLine(customerGroup.Key);
            //    foreach (Customer customer in customerGroup)
            //    {
            //        Console.WriteLine("{0},{1}", customer.City, customer.Age);
            //    }
            //}

            //var arr = (from cust in clist select new { Name = cust.Name, City = cust.City }).ToArray();
            ArrayList fruits = new ArrayList(4);
            fruits.Add("Mongo");
            fruits.Add("Mongo");
            fruits.Add("Mongo");
            fruits.Add(3.0);
            fruits.Add("Banana");
            var query1 = fruits.OfType<string>();
            foreach (string fruit in query1) {
                Console.WriteLine(fruit);
            }

      
            Console.ReadLine();
        }

        private static void basic()
        {
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            IEnumerable<int> numQuery = from num in numbers where (num % 2) == 0 select num;

            foreach (int num in numQuery)
            {
                Console.Write("{0}", num);
            }

            Console.WriteLine();
            Console.WriteLine(numQuery.Count());
            Console.WriteLine(numQuery.Average());
            Console.WriteLine(numQuery.First());
            Console.WriteLine(numQuery.Max());

            var arr = (from num in numbers where (num % 2) == 0 orderby num descending select num).ToList();
            Console.WriteLine(arr.ToString());
        }
    }

    class Pet
    {
        public string Name { get; set; }
        public double Age { get; set; }
    }
    class Customer {
        public string City { set; get; }
        public int Age { set; get; }
        public string Name { set; get; }

        public Customer(string city, int age,string name) {
            City = city;
            Age = age;
            Name = name;
        }

    }
}
