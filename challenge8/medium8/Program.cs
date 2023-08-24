namespace medium8;

class Program
{
    static void Main(string[] args)
    {
        //🌟Medium:  Oluşturduğunuz bir dizinin medyanını hesaplayan bir kod parçacığı yazar mısınız?

        Console.Write("Dizinin boyutunu girin:");
        int n = int.Parse(Console.ReadLine());

        int[] dizi = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}. elemani girin:",i+1);
            dizi[i]=int.Parse(Console.ReadLine());

        }

        Array.Sort(dizi);

        double medyan; 
        if( n%2 == 0)
        {   
            
            medyan = (double)(dizi[n/2] + dizi[(n/2)-1])/2;
        }

        else
        {
            medyan =dizi[(n-1)/2];
        }

        Console.WriteLine("Dizinin medyani : {0}",medyan);
    }
}
