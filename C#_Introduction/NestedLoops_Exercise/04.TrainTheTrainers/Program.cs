int juryCount = int.Parse(Console.ReadLine());

double totalSum = 0;
int totalGradesCount = 0;

while (true)
{
    string input = Console.ReadLine();
    if (input == "Finish") break;

    string presentationName = input;
    double gradeSum = 0;

    for (int i = 1; i <= juryCount; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        gradeSum += grade;
        totalSum += grade;
        totalGradesCount++;
    }

    double average = gradeSum / juryCount;
    Console.WriteLine($"{presentationName} - {average:F2}.");
}

Console.WriteLine($"Student's final assessment is {totalSum / totalGradesCount:F2}.");