using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDbFirst
{
    internal interface IRepository<T, K>
    {
        List<T> Get();
        void Add(T entity);
        T Delete(K id);
        T Update(T entity);
        T GetById(K id);
    }
}
