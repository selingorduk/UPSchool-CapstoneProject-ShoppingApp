using ShoppingApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Models
{
    public class ProductModel
    {
        //[Required]
        //[StringLength(60, MinimumLength = 10, ErrorMessage = "Ürün ismi minimum 10 karakter ve maksimum 60 karakter olmalıdır.")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        //[Range(1,1000)]
        public decimal Price { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
