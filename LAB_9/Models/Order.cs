using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab9_.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public Customer Customer { get; set; }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Product Product { get; set; }
    }
}
