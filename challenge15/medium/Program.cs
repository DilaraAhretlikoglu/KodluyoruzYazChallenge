using System;
namespace medium
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir metin almanızı istiyorum. Bu metnin içindeki en çok tekrar eden harfi bulmalı ve kaç kere tekrar ettiğini göstermeli.
            int sayisi = 0;
            int index_numarasi=0;
            Console.WriteLine("Metni Giriniz :");
            Console.WriteLine("==========================================");
            String metin = Console.ReadLine();
            metin = metin.ToLower();
            String karakterler = "0123456789abcdefghijklmnopqrstuvwxyz.?,;";
            int[] count = new int[karakterler.Length];
            for (int i = 0; i < metin.Length; i++)
            {
                int index = karakterler.IndexOf(metin[i]);
                if (index < 0)
                    continue;
                else
                {
                    count[index]++;
                }
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] < 1)
                    continue;
                else
                {
                    Console.WriteLine(karakterler[i] + " " + count[i]);
                }
            }
 
            //En fazla bulunan harf sayısı
            for (int i = 1; i < count.Length; i++)
            {
                if (sayisi < count[i])
                { 
                    sayisi = count[i];
                    index_numarasi = i; //Harf sayısı en fazla olan index numarası
                }
                    
            }   
            Console.WriteLine("En fazla olan karakter : " + karakterler[index_numarasi] + ", sayısı " + sayisi);
            Console.ReadKey();
        }
    }
}
