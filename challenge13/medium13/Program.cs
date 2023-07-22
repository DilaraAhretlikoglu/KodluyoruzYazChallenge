namespace medium13;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan bir kelime almanız gerekiyor. Bu kelimenin harflerini büyük harflere dönüştüren bir program yazmanızı istiyorum. 
        Console.WriteLine("Bir kelime giriniz:");
        string kelime=Console.ReadLine();

        string newKelime=kelime.ToUpper();

        Console.WriteLine("Orijinal kelime:{0}",kelime);
        Console.WriteLine("Büyük harfli kelime:{0}:",newKelime);
    }
}
