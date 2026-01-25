int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int minutesAfter15Seconds = minutes + 15;

if (minutesAfter15Seconds > 59)
{
    minutesAfter15Seconds -= 60;
    hours += 1;
}

if (hours == 24)
    hours = 0;

if (minutesAfter15Seconds < 10)
    Console.WriteLine($"{hours}:0{minutesAfter15Seconds}");
else
    Console.WriteLine($"{hours}:{minutesAfter15Seconds}");