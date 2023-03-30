using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductCategoryRelation>ProductCategories { get; set; }
    }
}
