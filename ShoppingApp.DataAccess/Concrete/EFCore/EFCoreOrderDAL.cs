using ShoopingApp.DataAccess.Abstract;
using ShoppingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoopingApp.DataAccess.Concrete.EFCore
{
    public class EFCoreOrderDAL:EFCoreGenericRepository<Order,ShoppingContext>,IOrderDAL
    {
    }
}
