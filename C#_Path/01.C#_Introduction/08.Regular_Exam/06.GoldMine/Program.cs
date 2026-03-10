int locations = int.Parse(Console.ReadLine());

for (int location = 1; location <= locations; location++)
{
    double expectedAvgGold = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());

    double totalObtainedGold = 0;
    for (int day = 1; day <= days; day++)
    {
        double obtainedGoldPerDay = double.Parse(Console.ReadLine());
        totalObtainedGold += obtainedGoldPerDay;
    }

    double obtainedAvgGold = totalObtainedGold / days;

    if (obtainedAvgGold >= expectedAvgGold) Console.WriteLine($"Good job! Average gold per day: {obtainedAvgGold:F2}.");
    else Console.WriteLine($"You need {expectedAvgGold - obtainedAvgGold:F2} gold.");
}