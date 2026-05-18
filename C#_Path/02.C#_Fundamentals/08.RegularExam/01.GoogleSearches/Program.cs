double incomeFromUser = double.Parse(Console.ReadLine());
int numberOfUsers = int.Parse(Console.ReadLine());
double totalMoney = 0.00;

for (int i = 1; i <= numberOfUsers; i++)
{
    int numberOfSearches = int.Parse(Console.ReadLine());
    double incomeFromSearches = incomeFromUser * numberOfSearches;

    if (numberOfSearches == 1) continue;
    
    if (i % 3 == 0) incomeFromSearches *= 3;
    
    if (numberOfSearches > 5) incomeFromSearches *= 2;

    totalMoney += incomeFromSearches;
}

Console.WriteLine($"Total money earned: {totalMoney:F2}");