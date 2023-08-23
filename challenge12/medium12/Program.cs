namespace medium12;

class Program
{
    static void Main(string[] args)
    {
        //🌟Medium:  Bir çiftlikte toplamda 36 baş tavuk ve koyun bulunmaktadır.Bu hayvanlardan toplamda 100 bacak çıkmaktadır.
        //Çiftlikte kaçar tane tavuk ve koyun olduğunu bulan kod parçacığını yazar mısın?
        int tavukSayisi=36;
        int koyunSayisi;
        int toplamBacakSayisi=100;
        koyunSayisi=(toplamBacakSayisi-(36*2))/4;
        Console.WriteLine("Bu çiftlikte {0} adet tavuk ve {1} adet koyun olmak üzere toplamda {2} adet hayvan vardir",tavukSayisi,koyunSayisi,tavukSayisi+koyunSayisi);
    }
}
