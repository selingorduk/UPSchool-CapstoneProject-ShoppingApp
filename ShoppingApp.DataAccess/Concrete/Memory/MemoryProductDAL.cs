using ShoopingApp.DataAccess.Abstract;
using ShoppingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoopingApp.DataAccess.Concrete.Memory
{
    public class MemoryProductDAL : IProductDAL
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            var products = new List<Product>()
            {
                new Product(){Id=1, Name="IPhone 11", ImageUrl="1.jpg", Price=15000 },
                new Product(){Id=2, Name="IPhone 12", ImageUrl="2.jpg", Price=20000 },
                new Product(){Id=3, Name="IPhone 13", ImageUrl="3.jpg", Price=25000 }
            };

            return products;
        }

        public IEnumerable<IProductDAL> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetByIdWithCategories()
        {
            throw new NotImplementedException();
        }

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<IProductDAL>.Create(IProductDAL entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<IProductDAL>.Delete(IProductDAL entity)
        {
            throw new NotImplementedException();
        }

        List<IProductDAL> IRepository<IProductDAL>.GetAll(Expression<Func<IProductDAL, bool>> filter)
        {
            throw new NotImplementedException();
        }

        IProductDAL IRepository<IProductDAL>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        IProductDAL IRepository<IProductDAL>.GetOne(Expression<Func<IProductDAL, bool>> filter)
        {
            throw new NotImplementedException();
        }

        IEnumerable<IProductDAL> IProductDAL.GetPopularProducts()
        {
            throw new NotImplementedException();
        }

        void IRepository<IProductDAL>.Update(IProductDAL entity)
        {
            throw new NotImplementedException();
        }
    }
}
