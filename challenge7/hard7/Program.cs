namespace hard7;

class Program
{
    static void Main(string[] args)
    {
        //💪🏻Hard: Kullanıcıdan aldığınız bir metnin içindeki sesli harfleri sayan ve bunu kullanıcıya geri dönen bir kod parçacığı yazar mısın?
        Console.Write("Bir metin girin: ");
        string metin = Console.ReadLine();

        int sesliHarfSayisi = SaySesliHarfler(metin);

        Console.WriteLine($"Metindeki sesli harf sayısı: {sesliHarfSayisi}");
    }

    static int SaySesliHarfler(string text)
    {
        string sesliHarfler = "aeıioöuüAEIİOÖUÜ";
        int sesliHarfSayisi = 0;

        foreach (char karakter in text)
        {
            if (sesliHarfler.Contains(karakter))
            {
                sesliHarfSayisi++;
            }
        }

        return sesliHarfSayisi;
    }
}
