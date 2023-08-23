namespace hard9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir cumle girin");
        string cumle = Console.ReadLine();

        if(IkilemeVarMi(cumle))
            Console.WriteLine(" Ikileme kullandınız.");
        else
            Console.WriteLine("Ikileme bulunamadı");
    }
    static bool IkilemeVarMi(string cumle)
    {
        string[] kelimeler = cumle.Split(" ");

        for(int i = 0; i < kelimeler.Length-1; i++)
        {
            if(kelimeler[i] == kelimeler[i+1])
                return true;
        }
        return false;
    }
}
