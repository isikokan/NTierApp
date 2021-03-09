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
            IProductService productService = new ProductManager(new EfProductDal());

            List<Product> productList = productService.GetAll();
            foreach (Product product in productList)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static void ProductDetailTest()
        {
            IProductService productService = new ProductManager(new EfProductDal());

            List<ProductDetailDto> productDetailList = productService.GetProductDetails();
            foreach (ProductDetailDto productDetail in productDetailList)
            {
                Console.WriteLine(productDetail.CategoryName);
            }
        }
    }
}
