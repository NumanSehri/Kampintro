using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Product product1= new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu";


            Product[] products = new Product[] {product1,product2 };

            foreach (Product product in products)
            {
               

                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("----------------------");

            }

            Console.WriteLine("----------------Metotlar----------------------");


            //instance-örnek
            //encapsulation
            //sepetmanager class çağırdık
            SepetManager sepetManager = new SepetManager();
            
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add1("Armut", "Yeşil Armut", 12);
            sepetManager.Add1("elma", "Yeşil Elma", 9);
            sepetManager.Add1("Karpuz", "Diyarbakır Karpuzu", 50);


        }
    }
}
//dont repeat yourself- clean code- best practice