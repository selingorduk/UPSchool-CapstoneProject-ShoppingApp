﻿using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        //private ICategoryService _categoryService;
        public HomeController(IProductService productService) //ICategoryService categoryService
        {
            _productService = productService;
            //_categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View(new ProductListModel()
            {
                Products = _productService.GetAll()
            });

            //Products = _productService.GetPopularProducts()

            //Categories = _categoryService.GetAll()

        }
        //return View(_productService.GetAll()); //direkt memory üzerinden tüm bilgiler gelir. düzeltilmeli!!!
    }

}

