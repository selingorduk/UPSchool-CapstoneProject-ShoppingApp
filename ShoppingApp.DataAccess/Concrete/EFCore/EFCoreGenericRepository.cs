using Microsoft.EntityFrameworkCore;
using ShoppingApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.DataAccess.Concrete.EFCore
{
    public class EFCoreGenericRepository<G, GContext> : IRepository<G>
        where G : class
        where GContext : DbContext, new()

    {
        public void Create(G entity)
        {
            using (var context= new GContext())
            {
                context.Set<G>().Add(entity);
                context.SaveChanges();
            }
            throw new NotImplementedException();
        }

        public void Delete(G entity)
        {
            using (var context = new GContext())
            {
                context.Set<G>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<G> GetAll(Expression<Func<G, bool>> filter = null)
        {
            using (var context = new GContext())
            {
                return filter == null
                         ? context.Set<G>().ToList()
                         : context.Set<G>().Where(filter).ToList();
            }
        }

        public G GetById(int id)
        {
            using (var context = new GContext())
            {
                return context.Set<G>().Find(id);
            }
        }

        public G GetOne(Expression<Func<G, bool>> filter)
        {
            using (var context = new GContext())
            {
                return context.Set<G>().Where(filter).SingleOrDefault();
            }
        }

        public void Update(G entity)
        {
            using (var context = new GContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        List<G> IRepository<G>.GetAll(Expression<Func<G, bool>> filter)
        {
            using (var context = new GContext())
            {
                return filter == null
                         ? context.Set<G>().ToList()
                         : context.Set<G>().Where(filter).ToList();
            }
        }
    }
}
