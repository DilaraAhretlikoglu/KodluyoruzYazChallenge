namespace easy11;

class Program
{
    static void Main(string[] args)
    {
        //🙌🏼 Easy: Kullanıcıdan aldığınız bir sayının faktöriyelini hesaplayan kod parçacığını yazmanızı istiyorum.

        Console.Write("Bir sayi giriniz:");
        int sayi = int.Parse(Console.ReadLine());

        faktoriyelHesapla(sayi);
    }
    static void faktoriyelHesapla(int sayi)
    {
        int carpim = 1;
        for(int i = 1; i <= sayi; i++)
        {
            carpim *= i;
        }
        Console.WriteLine("{0}! = {1}",sayi,carpim);

    }
}
