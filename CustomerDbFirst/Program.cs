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
            ICustomerRepository repository = new EFCustomerRepository();
            var customer = new RepoCustomer() { Id = 1, FirstName = "User", LastName = "Test", City = "New York", Country = "USA", Phone = "1234567890" };
            repository.Add(customer);
        }
    }
}
