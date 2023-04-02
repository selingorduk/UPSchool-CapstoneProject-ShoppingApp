using ShoppingApp.Business.Abstract;
using ShoopingApp.DataAccess.Abstract;
using ShoppingApp.Entities;
using System;
using System.Collections.Generic;

namespace ShopApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        //private IProductDAL _productDAL; //dataaccess'den interface olmalı!!!
        //public ProductManager(IProductDAL productDAL) //????

        private IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public bool Create(Product entity)
        {
            if (Validate(entity))
            {
                _productDAL.Create(entity);
                return true;
            }
            return false;
            
    }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _productDAL.GetAll(); //return _productDAL.GetAll(); //return (List<Product>)_productDAL.GetAll();           //methodları çağır
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetByIdWithCategories(int id)
        {
            return _productDAL.GetByIdWithCategories();
        }

        public List<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
        public string ErrorMessage { get;  set; }
        public bool Validate(Product entity)
        {
            var isValid = true;

            if (string.IsNullOrEmpty(entity.Name))
            {
                ErrorMessage += "!Ürün ismi girmelisiniz.";
                isValid = false;
            }

            return isValid;
        }
        

    }
}