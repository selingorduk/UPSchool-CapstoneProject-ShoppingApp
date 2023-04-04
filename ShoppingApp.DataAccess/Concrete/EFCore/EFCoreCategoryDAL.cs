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
    public class EFCoreCategoryDAL : EFCoreGenericRepository<Category, ShoppingContext>, ICategoryDAL


    {
        public void DeleteFromCategory(int categoryId, int productId)
        {
            using (var context = new ShoppingContext())
            {
                var cmd = @"delete from ProductCategoryRelation where ProductId=@p0 And CategoryId=@p1";
                context.Database.ExecuteSqlRaw(cmd, productId, categoryId); //command raw olarak değiştirildi.
            }
        }

        public Category GetByIdWithProducts(int id)
        {
            using (var context = new ShoppingContext())
            {
                return context.Categories
                        .Where(i => i.Id == id)
                        .Include(i => i.ProductCategories)
                        .ThenInclude(i => i.Product)
                        .FirstOrDefault();
            }
        }
    }
}
