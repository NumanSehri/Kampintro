using System;

namespace ClassIntroVeri
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Numan";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Numan ŞEHRİ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "F#";
            kurs2.Egitmen = "Burak Arif";
            kurs2.IzlenmeOrani = 15;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "R#";
            kurs3.Egitmen = "Arif İNCE";
            kurs3.IzlenmeOrani = 18;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Muro";
            kurs4.IzlenmeOrani = 100;


            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);
            //dizinin içinde kurs objesi tutuluyor. yani kurs class içindeki veriler tutuluyor
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " Hoca");

                         }

            Console.WriteLine("Hello World!");
        }
    }

    public class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
