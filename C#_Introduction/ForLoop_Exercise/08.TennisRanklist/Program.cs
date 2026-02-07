int tournaments = int.Parse(Console.ReadLine());
int startPoints = int.Parse(Console.ReadLine());

int totalPoints = startPoints;
int earnedPoints = 0;
int wins = 0;

for (int i = 0; i < tournaments; i++)
{
    string result = Console.ReadLine();
    switch (result)
    {
        case "W":
            earnedPoints += 2000;
            wins++;
            break;
        case "F":
            earnedPoints += 1200;
            break;
        case "SF":
            earnedPoints += 720;
            break;
    }
}

totalPoints += earnedPoints;
double averagePoints = Math.Floor(earnedPoints / tournaments * 1.0);
double winPercent = wins * 100.00 / tournaments;

Console.WriteLine($"Final points: {totalPoints}");
Console.WriteLine($"Average points: {averagePoints}");
Console.WriteLine($"{winPercent:F2}%");
