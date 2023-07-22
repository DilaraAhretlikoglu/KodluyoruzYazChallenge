namespace hard13;

class Program
{
    static void Main(string[] args)
    {
        //Bir şirket, bir ürünü üretmek ve satmak için belirli bir maliyet ve satış fiyatı hesaplamaktadır. Şirketin bir ürün için birim maliyeti ve birim satış fiyatı verildiğinde, kaç adet ürünün satılması durumunda şirketin kar edeceğini bulmanı istiyorum. 
        Console.WriteLine("Ürün maliyetini giriniz:");
        int cost=int.Parse(Console.ReadLine());
        Console.WriteLine("Ürün fiyatini giriniz:");
        int price=int.Parse(Console.ReadLine());

        int counter=1;
        int profit=0;

        while(counter>0)
        {
            profit=counter*(price-cost);
            if(profit>cost)
            {
                Console.WriteLine("Kaç ürün satılırsa kâr edilir?: {0}",counter);
                break;
            }
            counter++;
        }

    }
}
