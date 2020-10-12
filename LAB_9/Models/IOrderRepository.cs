using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab9_.Models
{
    public interface IOrderRepository
    {
        Order GetOrder(int id);
        IEnumerable<Order> GetAllOrders();
        Order Add(Order order);
        Order Update(Order order);
        Order Delete(int id);
    }
}
