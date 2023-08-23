namespace easy10;

class Program
{
    static void Main(string[] args)
    {
        //🙌🏼 Easy: Bir dizi tanımladıktan sonra bu dizinin içinden en büyük sayıyı bulan kod parçacığını yazar mısın?

        int[] dizi = {77,93,103,99,234,678,321,33,2,456,21};
        int max = 0;
        foreach (var i in dizi)
        {
            if(i > max)
                max = i;
        }
        Console.WriteLine("Dizinin en buyuk elemani : {0}",max);


        
    }
}
