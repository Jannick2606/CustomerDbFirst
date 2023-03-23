using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDbFirst
{
    internal interface ICustomer
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string City { get; set; }
        string Country { get; set; }
        string Phone { get; set; }
    }
}
