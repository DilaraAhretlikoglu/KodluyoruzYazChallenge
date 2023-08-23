namespace medium11;

class Program
{
    static void Main(string[] args)
    {
        // 🌟Medium:  Bir dizi oluşturup bu sayıların ortalamasını hesaplayan bir kod parçacığı yazar mısın?
        Console.WriteLine("Dizinizin boyutunu girin:");
        int n = int.Parse(Console.ReadLine());
        int[] dizi = new int[n];

        for(int i = 0; i < n; i++)
        {
           Console.WriteLine("Dizinizin {0}. elemanini girin:",i+1); 
           dizi[i] = int.Parse(Console.ReadLine());
        }
        int toplam = 0;
        for(int i = 0; i < n; i++)
        {
           toplam += dizi[i];
        
        }
        double ortalama = (double) toplam / n;

        Console.WriteLine("Dizinizin ortalamasi : {0}",ortalama); 

    }
}
