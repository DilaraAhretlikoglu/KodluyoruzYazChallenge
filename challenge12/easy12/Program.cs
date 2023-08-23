namespace easy12;

class Program
{
    static void Main(string[] args)
    {
        // Easy: Bir araba saatte 60 km hızla hareket ediyor. Bu araba kaç saatte 240 km yol alır?
        int speed = 60;
        int road =240;
        int time =roadCalculate(road,speed);
        
        Console.WriteLine("{0}km/h hızla giden bir araç {1} saatte 240 km yol alır.",speed,time);
    }
    static int roadCalculate(int road, int speed)
    {
        int time = road / speed;
        return time;
    }
}
