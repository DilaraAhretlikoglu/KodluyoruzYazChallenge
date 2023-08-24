namespace hard3;

class Program
{
    static void Main(string[] args)
    {
        //💪🏻Hard: Bir sınıfta 30 öğrenci bulunmaktadır. Öğrencilerden kaç farklı şekilde 4 kişi seçilebilir?😀🗝️ Bu problemi çözen kodu yazmanı istiyorum🤗
        Console.Write("Ogrenci sayisini girin:");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Kacarli secim yapilacak:");
        int r = int.Parse(Console.ReadLine());

        long secimSayisi = kombinasyonHesapla(n,r);

        Console.Write($"Öğrencilerden {secimSayisi} farklı şekilde {r} kişi seçilebilir?");


    }
    static long faktoriyelHesapla(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            else
                return num * faktoriyelHesapla(num - 1);
        }

     static long kombinasyonHesapla(int n, int r)
        {
            return faktoriyelHesapla(n) / (faktoriyelHesapla(r) * faktoriyelHesapla(n - r));
        }
}   
