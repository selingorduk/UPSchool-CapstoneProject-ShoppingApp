using Microsoft.EntityFrameworkCore;
using ShoppingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoopingApp.DataAccess.Concrete.EFCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShoppingContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if(context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }
                context.SaveChanges();
            }
        }
        private static Category[] Categories =
        {
            new Category () {Name="Telefon"},
            new Category () {Name="Bilgisayar"},
        };
        private static Product[] Products =
        {
            new Product () {Name="IPhone8" , Price =8000 , ImageUrl ="1.jpg"},
            new Product () {Name="IPhone8S" , Price =9000 , ImageUrl ="2.jpg"},
            new Product () {Name="IPhoneX" , Price =10000 , ImageUrl ="3.jpg"},
            new Product () {Name="IPhone11" , Price =160000 , ImageUrl ="4.jpg"},
            new Product () {Name="IPhone11Pro" , Price =170000 , ImageUrl ="5.jpg"},
            new Product () {Name="IPhone12" , Price =22000 , ImageUrl ="6.jpg"},
            new Product () {Name="IPhone13" , Price =29000 , ImageUrl ="7.jpg"},
        };
    }
}
