namespace medum1;

class Program
{
    static void Main(string[] args)
    {
        //🌟Medium:  Bir öğrenci kitap okuma hedefi olarak yılda 36 kitap okumayı belirledi. Eğer her ay eşit sayıda kitap okursa kaç kitap okumuş olur?
        int hedef = 36;
        int aylikOkunacakKitapSayisi=hedef/12;
        Console.WriteLine($"{hedef} adet kitabi her ay {aylikOkunacakKitapSayisi} adet okuyarak 1 yılda bitirebilirsin");
    }
}
