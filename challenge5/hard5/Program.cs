namespace hard5;

class Program
{
    static void Main(string[] args)
    {
        //💪🏻Hard: Kullanıcının girdiği bir sayı karekökten çıkıyorsa çıktığı halini eğer çıkmıyorsa karekökten tam olarak çıkmıyor hata mesajı veren kod parçacığını yazar mısın?

        Console.Write("Bir pozitif tam sayi girin:");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double sayi) && sayi > 0)
        {
            double karekok = Math.Sqrt(sayi);
            if (karekok % 1 == 0)
            {
                Console.WriteLine("{0} sayısının karekökü : {1} ", sayi, (int)karekok);
            }
            else
            {
                Console.WriteLine("Girilen sayının karekökü tam bir sayı değildir.");
            }
        }
        else
        {
            Console.WriteLine("Girilen sayı pozitif bir tam sayı değildir.");
        }
    }

}
    
