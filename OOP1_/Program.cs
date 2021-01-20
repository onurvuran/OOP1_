using System;

namespace OOP1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 2;

            Product product1 = new Product { Id = 2, CategoryId = 5,ProductName="pencel", 
            UnitPrice=2,UnitsInStock=10};

            PruductManager pruductManager = new PruductManager();
            pruductManager.Add(product1);

        }
    }
}
