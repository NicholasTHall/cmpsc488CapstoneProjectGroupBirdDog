using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Models
{
    public class ProductInventory
    {
        [Key]
        public int prod_id { get; set; }
        public int inv_bulk { get; set; }
        public int inv_shelf { get; set; }
        public Boolean stock_flag { get; set; }
    }
}
