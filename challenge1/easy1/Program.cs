using System;

namespace easy1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kirmizi top sayisi:");
            int kirmiziTopSayisi = int.Parse(Console.ReadLine());

            Console.Write("Yesil top sayisi:");
            int yesilTopSayisi = int.Parse(Console.ReadLine());

            Console.Write("Mavi top sayisi:");
            int maviTopSayisi = int.Parse(Console.ReadLine());

            int toplamTopSayisi = kirmiziTopSayisi + maviTopSayisi + yesilTopSayisi;

            double kirmiziOlasiligi = ((double)kirmiziTopSayisi / (double)toplamTopSayisi) * (((double)kirmiziTopSayisi - 1) / ((double)toplamTopSayisi - 1));
            double yesilOlasiligi = ((double)yesilTopSayisi / (double)toplamTopSayisi) * (((double)yesilTopSayisi - 1) / ((double)toplamTopSayisi - 1));
            double maviOlasiligi = ((double)maviTopSayisi / (double)toplamTopSayisi) * (((double)maviTopSayisi - 1) / ((double)toplamTopSayisi - 1));

            double ayniRenkOlasiligi = kirmiziOlasiligi + maviOlasiligi + yesilOlasiligi;
            double yuzdeCinsindenOlasilik = ayniRenkOlasiligi * 100;

            Console.WriteLine("İki topun aynı renk olma olasılığı: " + yuzdeCinsindenOlasilik.ToString("0.00") + "%");
        }
    }
}
