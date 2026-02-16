string name = Console.ReadLine();

int grades = 0;
int excluded = 0;
double avgGrade = 0;

while (grades <= 12)
{
    double yearGrade = double.Parse(Console.ReadLine());

    if (yearGrade < 4.00)
    {
        excluded++;
        if (excluded > 1) break;
        continue;
    }
    else
    {
        avgGrade += yearGrade;
        grades++;

    }
}

if (grades < 12) Console.WriteLine($"{name} has been excluded at {grades} grade");
else Console.WriteLine($"{name} graduated. Average grade: {avgGrade / 12:F2}");