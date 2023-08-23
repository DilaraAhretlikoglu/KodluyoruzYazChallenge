namespace medium10;

class Program
{
    static void Main(string[] args)
    {
        //🌟Medium:  Bir dizi oluşturup içindeki sayıların en büyük ve en küçük değerlerini bulan ve ekrana yazdıran bir kod parçacığı yazar mısınız?

        int[] dizi = {11,1,34,234,78,56,432,9,10,61};
        int max = dizi [0];
        int min = dizi [0];
        foreach (var i in dizi)
        {
            if(i>max)
            {
                max=i;
            }
            if(i<min)
            {
                min=i;
            }
        }
        Console.WriteLine("Dizinin en kucuk elemani : {0}, en buyuk elemani : {1}",min,max);
    }
}
