int students = int.Parse(Console.ReadLine());

int groupOne = 0;
int groupTwo = 0;
int groupThree = 0;
int groupFour = 0;

double totalGrdes = 0;

for (int student = 1; student <= students; student++)
{
    double grade = double.Parse(Console.ReadLine());

    if (grade < 3) groupFour++;
    else if (grade <= 3.99) groupThree++;
    else if (grade <= 4.99) groupTwo++;
    else groupOne++;

    totalGrdes += grade;
}

double averageGrade = totalGrdes / students;

Console.WriteLine($"Top students: {groupOne * 100.0 / students:F2}%");
Console.WriteLine($"Between 4.00 and 4.99: {groupTwo * 100.0 / students:F2}%");
Console.WriteLine($"Between 3.00 and 3.99: {groupThree * 100.0 / students:F2}%");
Console.WriteLine($"Fail: {groupFour * 100.0 / students:F2}%");
Console.WriteLine($"Average: {averageGrade:F2}");