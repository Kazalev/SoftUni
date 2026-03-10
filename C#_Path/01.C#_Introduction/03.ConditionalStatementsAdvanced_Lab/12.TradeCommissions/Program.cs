string city = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());

double commission = 0;
bool isValid = true;

if (sales < 0) isValid = false;
else if (city == "Sofia")
{
    if (sales <= 500) commission = sales * 0.05;
    else if (sales <= 1000) commission = sales * 0.07;
    else if (sales <= 10000) commission = sales * 0.08;
    else commission = sales * 0.12;
}
else if (city == "Varna")
{
    if (sales <= 500) commission = sales * 0.045;
    else if (sales <= 1000) commission = sales * 0.075;
    else if (sales <= 10000) commission = sales * 0.10;
    else commission = sales * 0.13;
}
else if (city == "Plovdiv")
{
    if (sales <= 500) commission = sales * 0.055;
    else if (sales <= 1000) commission = sales * 0.08;
    else if (sales <= 10000) commission = sales * 0.12;
    else commission = sales * 0.145;
}
else
{
    isValid = false;
}

if (!isValid)
    Console.WriteLine("error");
else
    Console.WriteLine($"{commission:F2}");
