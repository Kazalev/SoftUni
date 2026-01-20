double squareMeters = double.Parse(Console.ReadLine());

double price = squareMeters * 7.61;
double priceWithDiscount = price * (1 - 0.18);
double discount = price - priceWithDiscount;

Console.WriteLine($"The final price is: {priceWithDiscount} lv.");
Console.WriteLine($"The discount is: {discount} lv.");