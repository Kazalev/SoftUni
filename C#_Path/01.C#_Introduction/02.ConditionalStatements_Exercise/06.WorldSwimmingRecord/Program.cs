double record = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double timeForOneMeter = double.Parse(Console.ReadLine());

double totalSeconds = distance * timeForOneMeter;

double totalSecondsWithDelay = Math.Floor((distance / 15)) * 12.5 + totalSeconds;

if (totalSecondsWithDelay >= record)
    Console.WriteLine($"No, he failed! He was {totalSecondsWithDelay - record:F2} seconds slower.");
else
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalSecondsWithDelay:F2} seconds.");
