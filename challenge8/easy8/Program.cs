namespace easy8;

class Program
{
    static void Main(string[] args)
    {
        //🙌🏼 Easy: Kullanıcıdan aldığın sayının karesini hesaplayarak ekrana yazdıran kod parçacığını yazar mısın?

        Console.Write("Bir sayi girin:");
        int sayi = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} sayisinin karesi : {1}",sayi,KaresiniAl(sayi));
    }
    static int KaresiniAl(int sayi)
    {
        return sayi*sayi;
    }
}
