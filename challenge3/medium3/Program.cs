using System;

namespace Medium3
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplamTutar = 0;

            while (true)
            {
                Console.WriteLine("(1) Kitap : 80 TL");
                Console.WriteLine("(2) Defter : 20 TL");
                Console.WriteLine("(3) Kalem : 5 TL");
                Console.WriteLine("(4) Çıkış");
                
                Console.Write("Almak istediğiniz ürünün kodunu girin: ");
                int secim = int.Parse(Console.ReadLine());

                if (secim == 4)
                {
                    Console.WriteLine($"Toplam ödenecek tutar: {toplamTutar} TL");
                    break;
                }

                int adet = 0;
                int fiyat = 0;

                switch (secim)
                {
                    case 1:
                        Console.Write("Kitap sayisi: ");
                        adet = int.Parse(Console.ReadLine());
                        fiyat = 80;
                        break;
                    case 2:
                        Console.Write("Defter sayisi: ");
                        adet = int.Parse(Console.ReadLine());
                        fiyat = 20;
                        break;
                    case 3:
                        Console.Write("Kalem sayisi: ");
                        adet = int.Parse(Console.ReadLine());
                        fiyat = 5;
                        break;
                    default:
                        Console.WriteLine("Geçersiz giriş !");
                        continue;
                }

                toplamTutar += adet * fiyat;
            }
        }
    }
}
