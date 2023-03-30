using ShoppingApp.Entities;
using System.Collections.Generic;

namespace ShoppingApp.Business.Abstract
{
    public interface ICategoryService
    {
        List<Entities.Category> GetAll();
        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
    }
}
