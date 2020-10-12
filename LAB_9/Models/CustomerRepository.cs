using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab9_.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext context;
        public CustomerRepository(AppDbContext context)
        {
            this.context= context;
        }
        Customer ICustomerRepository.Add(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return customer;
        }

        Customer ICustomerRepository.Delete(int id)
        {
            Customer customer = context.Customers.Find(id);
            if (customer != null)
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
            return customer;
        }

        IEnumerable<Customer> ICustomerRepository.GetAllCustomer()
        {
            return context.Customers;

        }

        Customer ICustomerRepository.GetCustomer(int id)
        {
            return context.Customers.Find(id);
        }

        Customer ICustomerRepository.Update(Customer customerModified)
        {
            var customer = context.Customers.Attach(customerModified);
            customer.State= Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return customerModified;
        }
    }
}
