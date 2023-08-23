namespace medium9;

class Program
{
    static void Main(string[] args)
    {
        //🌟Medium: Bir dizi oluşturup içindeki çift sayıların toplamını hesaplayan bir kod parçacığı yazar mısınız?
        int[] dizi = {7,2,8,4,9,1,5,10,3,6};
        int toplam = 0;
        foreach (var i in dizi)
        {
            if (i % 2 == 0)
                toplam += i ;    
        }
        Console.WriteLine("Dizideki çift sayilarin toplam, : {0}",toplam);
    }
}
