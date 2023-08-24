namespace easy7;

class Program
{
    static void Main(string[] args)
    {
        //🙌🏼 Easy: Kullanıcıdan alınan bir kelimenin uzunluğunu hesaplayan bir kod parçacığı yazar mısın?
        Console.Write("Bir kelime girin:");
        string kelime = Console.ReadLine();

        int sayac = 0;

        foreach (var harf in kelime)
        {
            sayac++;
        }
        Console.WriteLine("'{0}' kelimesinin uzunluğu {1} harftir.",kelime,sayac);
    }
}
