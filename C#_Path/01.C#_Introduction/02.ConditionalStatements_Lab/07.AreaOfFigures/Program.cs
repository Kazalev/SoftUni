string figure = Console.ReadLine();

if(figure == "square")
{
    double sideLength = double.Parse(Console.ReadLine());
    Console.WriteLine(Math.Round(sideLength * sideLength, 3));
}
else if (figure == "rectangle")
{
    double sideLengthA = double.Parse(Console.ReadLine());
    double sideLengthB = double.Parse(Console.ReadLine());
    Console.WriteLine(Math.Round(sideLengthA * sideLengthB, 3));

}
else if (figure == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    Console.WriteLine(Math.Round(radius * radius * Math.PI, 3));
}
else if (figure == "triangle")
{
    double b = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    Console.WriteLine(Math.Round(0.50 * b * h, 3));
}

