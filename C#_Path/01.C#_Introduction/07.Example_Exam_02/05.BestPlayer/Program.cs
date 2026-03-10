string bestPlayerName = "";
int bestPlayerGoals = 0;

string playerName = "";
while ((playerName = Console.ReadLine()) != "END")
{
    int scoredGoals = int.Parse(Console.ReadLine());

    if (scoredGoals > bestPlayerGoals)
    {
        bestPlayerName = playerName;
        bestPlayerGoals = scoredGoals;

        if (scoredGoals >= 10) break;
    }
}

Console.WriteLine($"{bestPlayerName} is the best player!");

if (bestPlayerGoals >= 3) Console.WriteLine($"He has scored {bestPlayerGoals} goals and made a hat-trick !!!");
else Console.WriteLine($"He has scored {bestPlayerGoals} goals.");