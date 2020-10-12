using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab9_.Models
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int id);
        IEnumerable<Customer> GetAllCustomer();
        Customer Add(Customer customer);
        Customer Update(Customer customer);
        Customer Delete(int id);
    }
}
