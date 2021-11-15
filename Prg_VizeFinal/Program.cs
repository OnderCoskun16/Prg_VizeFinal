using System;

namespace Prg_VizeFinal
{
    using System;

    namespace VizeveFinal
    {
        class Program
        {
            private static int KişiSayisi;
            private static int VizeNotu, FinalNotu;
            private static double NotOrtalamasi;

            static void Main(string[] args)
            {
                // Console.WriteLine("Kaç kişinin Notlarını Girmek istiyorsunuz");
                //KişiSayisi = int.Parse(Console.ReadLine());

                Console.WriteLine("Vize Notunu Giriniz : ");
                VizeNotu = int.Parse(Console.ReadLine());

                Console.WriteLine("Final Notunu Giriniz : ");
                FinalNotu = int.Parse(Console.ReadLine());

                NotOrtalamasi = (VizeNotu * 0.40 + FinalNotu * 0.6);

                if (NotOrtalamasi >= 80 && NotOrtalamasi <= 100)
                {
                    Console.WriteLine("Notunuz AA ve Muhteşemsiniz Tebrikler. ");
                }
                else if (NotOrtalamasi >= 70 && NotOrtalamasi < 80)
                {
                    Console.WriteLine("Notunuz BA ve Tebrikler ");
                }
                else if (NotOrtalamasi >= 50 && NotOrtalamasi < 70)
                {
                    Console.WriteLine("Notunuz CC ve İdare Eder ");
                }
                else if (NotOrtalamasi >= 40 && NotOrtalamasi < 50)
                {
                    Console.WriteLine("Notunuz CB ve Tehlike çanları başladı ");
                }
                else if (NotOrtalamasi >= 30 && NotOrtalamasi < 20)
                {
                    Console.WriteLine("Notunuz DC ve Tebrikler ");
                }
                else if (NotOrtalamasi >= 20 && NotOrtalamasi < 30)
                {
                    Console.WriteLine("Notunuz DD ve Tebrikler ");
                }
                else
                {
                    Console.WriteLine("Notunuz FF ve Tebrikler ");
                }
                Console.WriteLine("Çıkmak için 2 kez bir tuşa basınız ");
                Console.ReadKey();
                Console.ReadKey();
            }
        }
    }

}
