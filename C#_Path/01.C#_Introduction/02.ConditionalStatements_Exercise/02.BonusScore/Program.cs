int points = int.Parse(Console.ReadLine());

double bonus = 0;

if (points <= 100)
    bonus = 5;
else if (points > 100 && points <= 1000)
    bonus = points * 0.20;
else
    bonus = points * 0.10;

if (points % 2 == 0)
    bonus += 1;

if (points % 10 == 5)
    bonus += 2;

Console.WriteLine(bonus);
Console.WriteLine(points + bonus);
