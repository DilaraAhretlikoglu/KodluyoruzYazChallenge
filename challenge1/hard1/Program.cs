using System;

namespace hard1
{
    class Program
    {
        static void Main(string[] args)
        {
            double ilkYarismaciHiz = 15; // km/saat
            double ikinciYarismaciHiz = 20; // km/saat

            double yakalamaSuresi = YakalamaSuresiHesapla(ilkYarismaciHiz, ikinciYarismaciHiz);

            Console.WriteLine($"İkinci yarışmacı, ilk yarışmacıyı {yakalamaSuresi} saat sonra yakalar.");
        }

        static double YakalamaSuresiHesapla(double ilkHiz, double ikinciHiz)
        {
            double hizFarki = ikinciHiz - ilkHiz;

            double yakalamaSuresi = 0;
            if (hizFarki > 0)
            {
                yakalamaSuresi = ilkHiz / hizFarki;
            }

            return yakalamaSuresi;
        }
    }
}
