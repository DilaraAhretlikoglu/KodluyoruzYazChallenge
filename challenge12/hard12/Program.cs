using System;

class Program
{
    static void Main(string[] args)
    {
        //💪🏻Hard: Bir yüzme havuzunda 2 adet su girişi, 1 adet su çıkışı vardır. İlk su girişi havuzu 10 saatte doldururken, ikinci su girişi havuzu 15 saatte doldurmaktadır. Havuzun kendiliğinden boşalma hızı ise 30 saatte bir doludur. Eğer havuz boşken, her iki su girişi de açılırsa havuz ne kadar sürede dolar?😀

        double ilkMusluk = 1.0 / 10.0;   
        double ikinciMusluk = 1.0 / 15.0; 
        double suCikisi = 1.0 / 30.0;  

        double toplamGiris = ilkMusluk + ikinciMusluk - suCikisi;
        double dolmaZamani = 1.0 / toplamGiris;

        Console.WriteLine("Havuzun dolması için gereken süre: {0} saat",dolmaZamani);
    }
}
