int n = int.Parse(Console.ReadLine());

int count1 = 0; // <200
int count2 = 0; // 200-399
int count3 = 0; // 400-599
int count4 = 0; // 600-799
int count5 = 0; // >=800

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (num < 200) count1++;
    else if (num <= 399) count2++;
    else if (num <= 599) count3++;
    else if (num <= 799) count4++;
    else count5++;
}

double p1 = count1 * 100.00 / n;
double p2 = count2 * 100.00 / n;
double p3 = count3 * 100.00 / n;
double p4 = count4 * 100.00 / n;
double p5 = count5 * 100.00 / n;

Console.WriteLine($"{p1:F2}%");
Console.WriteLine($"{p2:F2}%");
Console.WriteLine($"{p3:F2}%");
Console.WriteLine($"{p4:F2}%");
Console.WriteLine($"{p5:F2}%");
