using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDbFirst
{
    internal interface ICustomerRepository : IRepository<ICustomer, int>
    {
        List<ICustomer> Get();
        void Add(ICustomer customer);
        ICustomer Delete(int id);
        ICustomer Update(ICustomer customer);
        ICustomer GetById(int id);

    }
}
