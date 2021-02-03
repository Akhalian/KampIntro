using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName = "Bilgisayar"},
                new Category{CategoryId=2, CategoryName = "Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName = "Acer Laptop", QuantityPerUnit = "32 GB ram", Unitprice = 10000, UnitsInStock = 5},
                new Product{ProductId=2, CategoryId=1, ProductName = "Asus Laptop", QuantityPerUnit = "16 GB ram", Unitprice = 8000, UnitsInStock = 3},
                new Product{ProductId=3, CategoryId=1, ProductName = "Hp Laptop", QuantityPerUnit = "8 GB ram", Unitprice = 6000, UnitsInStock = 2},
                new Product{ProductId=4, CategoryId=2, ProductName = "Samsung Telefon", QuantityPerUnit = "8 GB ram", Unitprice = 5000, UnitsInStock = 15},
                new Product{ProductId=5, CategoryId=2, ProductName = "Apple Telefon", QuantityPerUnit = "4 GB ram", Unitprice = 8000, UnitsInStock = 0}
            };
            //Test(products);

            //GetProducts(products);

            //AnyTest(products);

            //lambda

            //FindTest(products);

            //FindAllTest(products);

            //AscDescTest(products);

            //ClassicLinqTest(products);

            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.Unitprice > 5000
                         orderby p.Unitprice descending
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.Unitprice };

            foreach (var productDto in result)
            {
                Console.WriteLine("{0} --- {1}",productDto.ProductName , productDto.ProductName);
            }

        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.Unitprice > 6000
                         orderby p.Unitprice descending, p.ProductName ascending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.Unitprice };

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.Unitprice).ThenByDescending(p => p.ProductName);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik-------------------------");

            foreach (var product in products)
            {
                if (product.Unitprice > 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }

            }

            Console.WriteLine("Linq-------------------------");

            var result = products.Where(p => p.Unitprice > 5000 && p.UnitsInStock > 3);

            foreach (var prodcut in result)
            {
                Console.WriteLine(prodcut.ProductName);
            }

            GetProducts(products);
        }

        private static void AnyTest(List<Product> products)
        {
            var result1 = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result1);
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.Unitprice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product);
                }

            }

            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.Unitprice > 5000 && p.UnitsInStock > 3).ToList();
        }


    }

    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }




}
