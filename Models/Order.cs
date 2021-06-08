using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulilled { get; set; }
        public int CustomerId { get; set; } // Foreign key rela to the customer table.

        public Customer Customer { get; set; } // Navigation prop, one customer per order.
        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
