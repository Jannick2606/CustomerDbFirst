using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDbFirst
{
    internal class EFCustomerRepository : ICustomerRepository
    {
        private readonly ERD_TestDBEntities context;
        public EFCustomerRepository()
        {
            context = new ERD_TestDBEntities();
        }
        public List<ICustomer> Get()
        {
            return context.Customers.ToList<ICustomer>();
        }
        public void Add(ICustomer iCustomer)
        {
            Customer customer = (Customer)iCustomer;
            context.Customers.Add(customer);
            context.SaveChanges();
        }
        public ICustomer Delete(int id)
        {
            Customer customer = context.Customers.Find(id);
            context.Customers.Remove(customer);
            context.SaveChanges();
            return customer;
        }
        public ICustomer Update(ICustomer customer)
        {
            context.Entry(customer).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return customer;
        }
        public ICustomer GetById(int id)
        {
            return context.Customers.Find(id);
        }
    }
}
