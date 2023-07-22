namespace easy13;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan bir sayı almanızı ve bu sayının asal olup olmadığını kullanıcıya söylemenizi istiyorum. 
        Console.WriteLine("Bir sayi girin:");
        int sayi=int.Parse(Console.ReadLine());
        int sayac=0;

        for (int i=1;i<=sayi;i++)
        {
            if(sayi%i==0)
                sayac++;
        }
        if(sayac==2)
            Console.WriteLine("{0} bir asal sayidir.",sayi);
        else
            Console.WriteLine("{0} bir asal sayi degildir.",sayi);

    }
}
