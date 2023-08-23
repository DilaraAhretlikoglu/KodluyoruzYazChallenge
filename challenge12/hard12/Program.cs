using System;

class Program
{
    static void Main(string[] args)
    {
        double ilkMusluk = 1.0 / 10.0;   
        double ikinciMusluk = 1.0 / 15.0; 
        double suCikisi = 1.0 / 30.0;  

        double toplamGiris = ilkMusluk + ikinciMusluk - suCikisi;
        double dolmaZamani = 1.0 / toplamGiris;

        Console.WriteLine("Havuzun dolması için gereken süre: {0} saat",dolmaZamani);
    }
}
