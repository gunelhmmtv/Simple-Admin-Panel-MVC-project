using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogicLayer.DTOs
{
    public class ProductViewDto
    {
        public int Id { get; set; }

        public string ProductName { get; set; } = string.Empty;

        //public string ImgUrl { get; set; } = string.Empty; 

        public double Price { get; set; }

        public int StockCount { get; set; }

    }
}
