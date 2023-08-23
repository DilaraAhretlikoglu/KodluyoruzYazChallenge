namespace hard10;

class Program
{
    static void Main(string[] args)
    {
        //💪🏻Hard: Kullanıcının girdiği bir sayının tam bölenlerinin toplamını hesaplayan bir kod parçacığı yazınız.

        Console.Write("Bir sayi giriniz:");
        int sayi = int.Parse(Console.ReadLine());

        List<int> tamBolenler = TamBolenleriBul(sayi);
        int toplam = 0;
        foreach (var i in tamBolenler)
        {
            toplam+=i;
        }

        Console.WriteLine("{0} sayisinin tam bölenleri toplami : {1}",sayi,toplam);
    }
    static List<int> TamBolenleriBul(int sayi)
    {
        List<int> tamBolenler = new List<int>();

        for(int i = 1 ; i<=sayi ; i++)
        {
            if(sayi % i == 0)
                tamBolenler.Add(i);
        }
        return tamBolenler;
    }
}
