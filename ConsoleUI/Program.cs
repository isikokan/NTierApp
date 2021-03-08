using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new EfProductDal());

            List<Product> productList = productService.GetAll();
            foreach (Product product in productList)
            {
                Console.WriteLine(product.ProductName);
            }
            Console.ReadLine();
        }
    }
}
