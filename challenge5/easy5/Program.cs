namespace easy5;

class Program
{
    static void Main(string[] args)
    {
        // 🙌🏼 Easy: Kullanıcıdan aldığın iki sayının toplamını ekrana yazdıran bir kod parçacığı yazar mısın?

        Console.Write("İlk sayiyi girin:");
        int sayi1 = int.Parse(Console.ReadLine());

        Console.Write("İkinci sayiyi girin:");
        int sayi2 = int.Parse(Console.ReadLine());

        int sonuc = topla(sayi1,sayi2);

        Console.WriteLine("{0} + {1} = {2}",sayi1,sayi2,sonuc);

    }
    static int topla(int sayi1,int sayi2)
    {
        return sayi1 + sayi2;
    }
}
