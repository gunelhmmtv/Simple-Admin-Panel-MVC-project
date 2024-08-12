using ProjectEntities.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities.Concrete.Classes
{
    public class Product : BaseEntity
    {
        public Product()
        {
            ProductOrders = new HashSet<ProductOrder>();
        }
        public string ProductName { get; set; }=string.Empty;

        //public string ImgUrl { get; set; }= string.Empty;
        public double Price { get; set; }

        public int StockCount { get; set; }

        public ICollection<ProductOrder> ProductOrders { get; set; }


    }

}
