namespace easy3;

class Program
{
    static void Main(string[] args)
    {
        //🙌🏼 Easy: Bir futbol maçında 3 puanlık atışlarda 5 kez isabet edildi, 2 puanlık atışlarda ise 10 kez isabet edildi. Toplam kaç puan elde edildi?

        Console.Write("3 puanlık atışlardaki isabet sayisi :");
        int ucPuanlikAtis = int.Parse(Console.ReadLine());

        Console.Write("2 puanlık atışlardaki isabet sayisi :");
        int ikiPuanlıkAtis = int.Parse(Console.ReadLine());

        int toplamPuan = ucPuanlikAtis * 3 + ikiPuanlıkAtis * 2 ;

        Console.WriteLine("Toplam puanınız : {0}",toplamPuan);

    }
}
