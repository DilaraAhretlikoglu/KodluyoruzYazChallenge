namespace easy9;

class Program
{
    static void Main(string[] args)
    {
        //🙌🏼 Easy: Kullanıcıdan aldığınız sayının tek mi çift mi olduğunu ekrana yazdıran bir kod parçacığı yazar mısın?

        Console.Write("Bir sayi girin:");
        int sayi = int.Parse(Console.ReadLine());

        if(sayi % 2 == 0)
            Console.WriteLine("{0} bir cift sayidir.",sayi);
        else
             Console.WriteLine("{0} bir tek sayidir.",sayi);

    }
}
