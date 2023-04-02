using ShoppingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoopingApp.DataAccess.Abstract
{
    public interface IProductDAL:IRepository<Product>
    {
        IEnumerable<IProductDAL> GetPopularProducts();
        Product GetByIdWithCategories();
        //IEnumerable<IProductDAL> GetAll();


        //Product GetByIs(int id);
        //IQueryable<Product> GetAll(Expression<Func<Product, bool>> filter);
        //void Create(Product entity);
        //void Update(Product entity);
        //void Delete(Product entity);
    }
}
