using System.Numerics;

int numberOfBalls = int.Parse(Console.ReadLine());
int bestSnow = 0;
int bestTime = 0;
int bestQuality = 0;
BigInteger bestValue = 0;

for (int i = 0; i < numberOfBalls; i++)
{
    int snow = int.Parse(Console.ReadLine());
    int time = int.Parse(Console.ReadLine());
    int quality = int.Parse(Console.ReadLine());

    BigInteger value = snow / (BigInteger)time;
    value = BigInteger.Pow(value, quality);

    if (bestValue < value)
    {
        bestValue = value;
        bestSnow = snow;
        bestTime = time;
        bestQuality = quality;
    }
}

Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");