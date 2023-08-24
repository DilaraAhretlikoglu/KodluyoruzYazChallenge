namespace medium5;

class Program
{
    static void Main(string[] args)
    {
        // 🌟Medium:  Kullanıcıdan alınan bir metindeki kelime sayısını hesaplayan bir kod parçacığı yazar mısın?

        Console.Write("Bir metin girin:");
        string metin = Console.ReadLine();

        string[] kelimeler = metin.Split(' ');

        int kelimeSayisi = kelimeSay(kelimeler);

        Console.WriteLine($"Metindeki kelime sayısı: {kelimeSayisi}");
    
    }
    static int kelimeSay(string[] kelimeler)
    {
        int sayac = 0;
        foreach (var i in kelimeler)
        {
            sayac++;
        }
        return sayac;
    }
}
