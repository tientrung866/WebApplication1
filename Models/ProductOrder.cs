using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ProductOrder
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; } // Foreign key rela to the customer table.
        public int OrderId { get; set; } // Foreign key rela to the customer table.

        public Order Order { get; set; } // Navigation prop, one customer per order.
        public Product Product { get; set; }
    }
}
