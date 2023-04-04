using Microsoft.EntityFrameworkCore;
using ShoppingApp.DataAccess.Abstract;
using ShoppingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.DataAccess.Concrete.EFCore
{
    public class EFCoreProductDAL : EFCoreGenericRepository<Product, ShoppingContext>, IProductDAL
    {
        public IEnumerable<IProductDAL> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetByIdWithCategories(int id)
        {
            using (var context = new ShoppingContext())
            {
                return context.Products
                        .Where(i => i.Id == id)
                        .Include(i => i.ProductCategories)
                        .ThenInclude(i => i.Category)
                        .FirstOrDefault();
            }
        }

        public Product GetByIdWithCategories()
        {
            throw new NotImplementedException();
        }

        //buradan sonrası cut.


        IEnumerable<IProductDAL> IProductDAL.GetPopularProducts()
        {
            throw new NotImplementedException();
        }

        
    }
}
