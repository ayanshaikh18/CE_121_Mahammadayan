using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab9_.Models
{
    public class OrderRepository:IOrderRepository
    {
        private readonly AppDbContext context;
        public OrderRepository(AppDbContext context)
        {
            this.context = context;
        }
        Order IOrderRepository.Add(Order order)
        {
            order.CustomerName = context.Customers.Find(order.CustomerId).Name;
            order.ProductName = context.Products.Find(order.ProductId).Name;
            context.Orders.Add(order);
            context.SaveChanges();
            return order;
        }

        Order IOrderRepository.Delete(int id)
        {
            Order order = context.Orders.Find(id);
            if (order != null)
            {
                context.Orders.Remove(order);
                context.SaveChanges();
            }
            return order;
        }

        IEnumerable<Order> IOrderRepository.GetAllOrders()
        {
            return context.Orders;

        }

        Order IOrderRepository.GetOrder(int id)
        {
            return context.Orders.Find(id);
        }

        Order IOrderRepository.Update(Order orderModified)
        {
            orderModified.CustomerName = context.Customers.Find(orderModified.CustomerId).Name;
            orderModified.ProductName = context.Products.Find(orderModified.ProductId).Name;
            var order = context.Orders.Attach(orderModified);
            order.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return orderModified;
        }
    }
}
