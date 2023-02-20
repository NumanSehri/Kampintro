using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-dizi yazılımını hatırlamadım
            //string[] kurslar=new string[]{veriler bu kısma yazılır};
            
            string[] sehri =new string[]
                {"Celil", "Pamuk", "Mustafa", "Samet", "Ramazan", "Numan","Damla" };

            string kurs1 = "Yazılım Geliştiici Yetiştirme Kampı";
            string kurs2 = "Programlama Başlangıç İçin Temel Kurs";
            string kurs3 = "Java Kursu";
            string[] kurslar = new string[]
                {"Yazılım Geliştiici Yetiştirme Kampı","Programlama Başlangıç İçin Temel Kurs","Java Kursu","C++"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            for (int i = 0; i < sehri.Length; i++)
            {
                Console.WriteLine(sehri[i]);
            }

            Console.WriteLine("For Dongüsü Tamamlandı");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Döngü Tamamlandı, Kurslar ve sehri ailesi ekrana Fışkırttı");
        }
    }
}
