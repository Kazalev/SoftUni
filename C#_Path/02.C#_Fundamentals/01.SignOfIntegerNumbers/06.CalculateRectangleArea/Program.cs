double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

double result = CalculateArea(width, height);
Console.WriteLine(result);

static double CalculateArea(double width, double height)
{
    return width * height;
}