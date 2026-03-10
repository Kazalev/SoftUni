int pages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

double neededHoursPerDay = pages / pagesPerHour / days;

Console.WriteLine(neededHoursPerDay);