using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDACLocalFarmerProduce.Models
{
    public class Product
    {
        public int ProductID { get; set; } // PK for the table
        public string ProductName { get; set; }
        public DateTime ProductHarvestDate { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}
