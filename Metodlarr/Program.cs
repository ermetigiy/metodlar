using System;

namespace Metodlarr
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            //string urunAdi = "Çilek";
            //double fiyati = 10;
            //string aciklama = "Çilek gibi çilek";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati= 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};
   
            foreach (Urun urun in urunler) 
            { 
               Console.WriteLine(urun.Adi);
               Console.WriteLine(urun.Fiyati);
               Console.WriteLine(urun.Aciklama);
               Console.WriteLine("---------------------------");
            }

            Console.WriteLine("---------------Metodlar------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);



        }
    }
}
