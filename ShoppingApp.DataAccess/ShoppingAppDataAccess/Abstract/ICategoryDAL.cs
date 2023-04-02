using ShoppingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoopingApp.DataAccess.Abstract
{
    public interface ICategoryDAL : IRepository<Category>
    {
        //Category GetByIs(int id);
        //Category GetOne(Expression<Func<Category, bool>> filter);
        //IQueryable<Category> GetAll(Expression<Func<Category, bool>> filter);
        //void Create(Category entity);
        //void Update(Category entity);
        //void Delete(Category entity);
        Category GetByIdWithProducts(int id);
        void DeleteFromCategory(int categoryId, int productId);
    }
}
