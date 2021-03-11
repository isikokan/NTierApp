using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            ProductDetailTest();

            Console.ReadLine();
        }

        static void ProductTest()
        {
            IProductService productService = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            foreach (var product in productService.GetAll().Data)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static void ProductDetailTest()
        {
            IProductService productService = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            foreach (var productDetail in productService.GetProductDetails().Data)
            {
                Console.WriteLine(productDetail.CategoryName);
            }
        }
    }
}
