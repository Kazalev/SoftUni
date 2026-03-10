string seriesName = Console.ReadLine();
int seriesLength = int.Parse(Console.ReadLine());
int breakLength = int.Parse(Console.ReadLine());

double timeLeft = 0;

double timeForLunch = breakLength * 0.125;
double timeForRelax = breakLength * 0.25;

timeLeft = breakLength - timeForLunch - timeForRelax;

if (timeLeft >= seriesLength)
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeLeft - seriesLength)} minutes free time.");
else
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(Math.Abs(timeLeft - seriesLength))} more minutes.");
