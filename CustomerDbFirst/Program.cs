using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddCustomer("John", "Doe", "New York", "USA", "123-456-7890");
            GetCustomerById(15);
            UpdateCustomerFirstName(15, "Jane");
            GetCustomerById(15);
            DeleteCustomer(20);
            
        }
        static void AddCustomer(string first, string last, string city, string country, string phone)
        {
            using (var context = new ERD_TestDBEntities())
            {
                Customer customer = new Customer()
                {
                    FirstName = first,
                    LastName = last,
                    City = city,
                    Country = country,
                    Phone = phone
                };
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        static void DeleteCustomer(int id)
        {
            using (var context = new ERD_TestDBEntities())
            {
                Customer customer = context.Customers.Find(id);
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }
        static void UpdateCustomerFirstName(int id, string name)
        {
            using (var context = new ERD_TestDBEntities())
            {
                Customer customer = context.Customers.Find(id);
                customer.FirstName = name;
                context.SaveChanges();
            }
        }
        static void GetCustomerById(int id)
        {
            using (var context = new ERD_TestDBEntities())
            {
                Customer customer = context.Customers.Find(id);
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
                Console.WriteLine(customer.Phone);
                Console.ReadKey();
            }
        }
    }
}
