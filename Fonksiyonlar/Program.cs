using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mesaj();
            //selam("Erdem");
            //selam("Burak");
            //toplam(5, 4);
            //yuzdeOn(50);

            Console.WriteLine("Buraya Adınızı Girin");
            string ad = Console.ReadLine();
            ad = mesajlar(ad);
            Console.WriteLine(ad);
            ad = ad.ToUpper(); // ben ne şekilde yazarsam yazayım büyük harf yazıp bana gösterir
            Console.WriteLine(ad);
            ad = ad.ToLower(); //küçük harfe çevirir
            Console.WriteLine(ad);




            string mesajlar(string konu)
            {
                return $"Bu Mesaj Geri Veri Gönderir {konu}";
            }


            void yuzdeOn(int yüzde)
            {
                int sy = (yüzde* 10) / 100;
                 Console.WriteLine($"Girilen Sayımı yüzde onu : {sy}");
            }

            



            void Mesaj()
            {
                Console.WriteLine("Merhaba Arkadaşlar");
            }



            void selam(string kelime)
            {
                Console.WriteLine($"{kelime} ekrana yazıldı");
            }
            //GERİYE VERİ DÖNDERMEYE YANİ İŞLEM İÇİNDE YAPILIYOR
            //VE KALIYOR


            

            void toplam (int sayi, int sayi2)
            {
                int top = sayi + sayi2; 
                Console.WriteLine($"Toplama İşlemin Sonucu:{top}");
            }








            Console.ReadKey();
        }
    }
}
