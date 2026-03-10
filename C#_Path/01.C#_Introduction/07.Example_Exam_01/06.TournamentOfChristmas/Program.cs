int days = int.Parse(Console.ReadLine());
int totalWins = 0;
int totalLoses = 0;
double totalMoney = 0;

for (int day = 1; day <= days; day++)
{
    string sport = "";
    double dailyMoney = 0;
    int dailyWins = 0;
    int dailyLoses = 0;

    while ((sport = Console.ReadLine()) != "Finish")
    {
        string result = Console.ReadLine();

        if (result == "win")
        {
            dailyMoney += 20;
            dailyWins++;
        }
        else if (result == "lose")
        {
            dailyLoses++;
        }
    }

    if (dailyWins > dailyLoses)
    {
        dailyMoney *= 1.10;
        totalWins++;
    }
    else
    {
        totalLoses++;
    }

    totalMoney += dailyMoney;
}

if (totalWins > totalLoses) Console.WriteLine($"You won the tournament! Total raised money: {totalMoney *= 1.20:F2}");
else Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:F2}");