using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // Do not repeat yourself - Kendini tekrarlama

            // değer tutucu, alias
            string katagoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }

            Console.WriteLine(katagoriEtiketi);

        }
    }
}