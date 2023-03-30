using ShoppingApp.Entities;
using System.Collections.Generic;

namespace ShoppingApp.Business.Abstract
{
    public interface IProductService
    {
        Product GetByID(int id);
        List<Product> GetAll();
        List<Product> GetPopularProducts();
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}
