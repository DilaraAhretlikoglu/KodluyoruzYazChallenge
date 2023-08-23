namespace hard11;

class Program
{
    static void Main(string[] args)
    {
        //💪🏻Hard: Bir sıralanmış dizide (örneğin, artan sırada) hedef bir sayının kaç kez tekrar ettiğini bulan bir kod parçacığı yazar mısın?
         int[] siraliDizi = { 1, 2, 2, 3, 4, 4, 4, 5, 5, 5, 5, 6, 7, 7, 7, 7, 7 };
            int hedefSayi = 5;

            int frekans = FrekansiHesapla(siraliDizi, hedefSayi);
            Console.WriteLine("{0} sayisi sirali dizide {1} adet var",hedefSayi,frekans);
    }
    static int FrekansiHesapla(int[] siraliDizi, int hedefSayi)
    {
        int sayac = 0;
        foreach (var i in siraliDizi)
        {
            if( i == hedefSayi)
                sayac++;
        }
        return sayac;
    }

}
