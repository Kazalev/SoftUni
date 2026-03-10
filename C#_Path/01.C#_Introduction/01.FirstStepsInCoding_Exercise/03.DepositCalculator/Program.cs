double deposit = double.Parse(Console.ReadLine());
int depositTermInMounts = int.Parse(Console.ReadLine());
double yearInterestPercentage = double.Parse(Console.ReadLine());

double totalSumInEndOfPerion = deposit + depositTermInMounts * ((deposit * (yearInterestPercentage / 100)) / 12);

Console.WriteLine(totalSumInEndOfPerion);