namespace hard8;

class Program
{
    //💪🏻Hard: Kullanıcıdan aldığınız bir sayının Armstrong sayısı olup olmadığını kontrol eden bir kod parçacığı yazar mısınız? (Armstrong sayısı: Basamaklarının üçüncü kuvvetinin toplamı, sayıya eşit olan sayılardır.)

    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int number = int.Parse(Console.ReadLine());

        if (IsArmstrongNumber(number))
        {
            Console.WriteLine($"{number} bir Armstrong sayısıdır.");
        }
        else
        {
            Console.WriteLine($"{number} bir Armstrong sayısı değildir.");
        }
    }

    static bool IsArmstrongNumber(int num)
    {
        int originalNum = num;
        int sum = 0;
        int numOfDigits = (int)Math.Floor(Math.Log10(num) + 1);

        while (num > 0)
        {
            int digit = num % 10;
            sum += (int)Math.Pow(digit, numOfDigits);
            num /= 10;
        }

        return sum == originalNum;
    }
}
