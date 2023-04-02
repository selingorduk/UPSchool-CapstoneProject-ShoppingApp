using ShoppingApp.Entities;
using System.Collections.Generic;

namespace ShoppingApp.Business.Abstract
{
    public interface IProductService:IValidator<Product>
    {
        Product GetById(int id);
        
        Product GetByIdWithCategories(int id);
        List<Product> GetAll();
        List<Product> GetPopularProducts();
        bool Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        
    }
}
