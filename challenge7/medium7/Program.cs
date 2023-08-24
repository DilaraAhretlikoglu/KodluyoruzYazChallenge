namespace medium7;

class Program
{
    static void Main(string[] args)
    {
        //🌟Medium:  Kullanıcıdan aldığınız bir sayının basamaklarının toplamını hesaplayan bir kod parçacığı yazar mısın?

        Console.Write("Bir sayi girin:");
        int sayi = int.Parse(Console.ReadLine());

        int toplam = 0;
        int temp = sayi;
        while(temp > 0)
        {
            int basamak = temp % 10;
            toplam += basamak;
            temp /= 10;
        }
        Console.WriteLine("{0} sayisinin basamaklari toplami : {1}", sayi, toplam);
    }
}
