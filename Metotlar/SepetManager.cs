using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
   public class SepetManager
    {
        //naming convetion
        //syntax
        public void Add(Product product)
            //----------Parametre Verme
        {
            Console.WriteLine("Tebrikler Sepete Eklendi! : " + product.Adi );



        }

        public void Add1(string productName, string productInfo,double productPrice)
        {
            Console.WriteLine("Tebrikler. Sepete Ürün Eklendi : " + productName);


        }


    }
}
