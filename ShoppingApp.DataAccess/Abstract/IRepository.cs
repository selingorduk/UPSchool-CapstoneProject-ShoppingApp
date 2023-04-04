using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.DataAccess.Abstract
{
    public interface IRepository<GI> //Generic Interface
    {
        GI GetById(int id);
        GI GetOne(Expression<Func<GI, bool>> filter);
        List<GI> GetAll(Expression<Func<GI, bool>> filter = null); //IEnumerable List yapıldı.
        void Create(GI entity);
        void Update(GI entity);
        void Delete(GI entity);
    }
}
