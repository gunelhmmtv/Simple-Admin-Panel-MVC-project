using ProjectEntities.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities.Concrete.Classes
{
    public class Order : BaseEntity
    {
        public Order()
        {
            ProductOrders = new HashSet<ProductOrder>();
            Customer = new Customer();
        }
        public int OrderNumber { get; set; }
        public double TotalPrice { get; set; }

        public int Quantity { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
