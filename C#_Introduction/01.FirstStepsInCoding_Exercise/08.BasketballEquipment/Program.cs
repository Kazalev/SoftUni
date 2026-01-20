int yearTaxForTraining = int.Parse(Console.ReadLine());

double sneakers = yearTaxForTraining - (yearTaxForTraining * 0.40);
double outfit = sneakers - (sneakers * 0.20);
double ball = outfit * 0.25;
double accessories = ball * 0.20;

Console.WriteLine(yearTaxForTraining + sneakers + outfit + ball + accessories);
