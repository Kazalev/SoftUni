string fruit = Console.ReadLine();
string day = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double price = 0;

if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
{
    if (fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes")
    {
        if (fruit == "banana")
            price = quantity * 2.50;
        else if (fruit == "apple")
            price = quantity * 1.20;
        else if (fruit == "orange")
            price = quantity * 0.85;
        else if (fruit == "grapefruit")
            price = quantity * 1.45;
        else if (fruit == "kiwi")
            price = quantity * 2.70;
        else if (fruit == "pineapple")
            price = quantity * 5.50;
        else if (fruit == "grapes")
            price = quantity * 3.85;

        Console.WriteLine($"{price:F2}");
    }
    else
        Console.WriteLine("error");

}
else if (day == "Saturday" || day == "Sunday")
{
    if (fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes")
    {
        switch (fruit)
        {
            case "banana":
                price = quantity * 2.70;
                break;
            case "apple":
                price = quantity * 1.25;
                break;
            case "orange":
                price = quantity * 0.90;
                break;
            case "grapefruit":
                price = quantity * 1.60;
                break;
            case "kiwi":
                price = quantity * 3.00;
                break;
            case "pineapple":
                price = quantity * 5.60;
                break;
            case "grapes":
                price = quantity * 4.20;
                break;
        }

        Console.WriteLine($"{price:F2}");
    }
    else
        Console.WriteLine("error");

}
else
    Console.WriteLine("error");
