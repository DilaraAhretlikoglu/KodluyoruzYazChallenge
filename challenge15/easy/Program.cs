using System;
namespace easy
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcının doğum tarihini alarak kaç yaşında olduğunu bulan bir algoritma yazınız.
            Console.WriteLine("Lutfen dogum yilinizi giriniz:");
            int dogum_yili=int.Parse(Console.ReadLine());

            int bulundugumuz_yil=DateTime.Now.Year;
            
            while(dogum_yili>bulundugumuz_yil)
            {
                Console.WriteLine("Dogum yiliniz bulundugunuz yildan buyuk olamaz!!");
                Console.WriteLine("Lutfen dogum yilinizi giriniz:");
                dogum_yili=int.Parse(Console.ReadLine());
            }
            
            int yas=bulundugumuz_yil-dogum_yili;
            Console.WriteLine(yas + "yasindasiniz");
        }
    }
}

