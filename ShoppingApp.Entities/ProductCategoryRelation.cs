using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Entities
{
    public class ProductCategoryRelation
    {
        //public int Id { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
