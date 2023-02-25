using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product {Id=2,CategoryId=5,UnitInStock=5,
                ProductName="Kalem",UnitPrice=15};


            //Pascal Case  --  CamelCase
            //Case sensitive

            ProductManager productManager = new ProductManager();
            productManager.Add(product1); //Product metot ile ürün ekledim
            Console.WriteLine(product1.ProductName);

            int toplamaSonucu = productManager.Topla(9,5);
            Console.WriteLine(toplamaSonucu + " Toplm sonucu Return ile geri döndü");
            productManager.Topla2(5,8);
        }
    }
}
