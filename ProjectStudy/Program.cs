using System;

namespace ProjectStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Monster Laptop";
            product1.ProductPrice = 19000;
            product1.ProductStock = 10;

            Product product2 = new Product();
            product2.ProductName = "Lg Monitör";
            product2.ProductPrice = 4000;
            product2.ProductStock = 5;

            Product product3 = new Product();
            product3.ProductName = "SSD 480gb";
            product3.ProductPrice = 2300;
            product3.ProductStock = 6;

            Product product4 = new Product();
            product4.ProductName = "Logitech klavye";
            product4.ProductPrice = 1000;
            product4.ProductStock = 4;
            //4 adet ürünün adı, fiyatı ve stok durumu tutan class oluşturup 4 tane ürün ekledik

            Product[] products = new Product[]
            {product1,product2,product3,product4};
            //Product larımı dizi tanımladık

            foreach (var product in products)
            {
                Console.WriteLine("Ürün Adı:" + product.ProductName);
                Console.WriteLine("Fiyatı:" + product.ProductPrice);
                Console.WriteLine("Stok Durumu:" + product.ProductStock);
            }
            int i = 0;
            
            while (i<products.Length)
            {
                
                Console.WriteLine("While Döngüsü ile yazıldı " + products[i].ProductName);
                i++;
            }

            Console.WriteLine("Ürünlerimiz Listelendi");
        }



        public class Product
        {
            public string ProductName { get; set; }
            public int ProductPrice { get; set; }
            public int ProductStock { get; set; }



        }
            
            


    }


}
