double partyPrice = double.Parse(Console.ReadLine());
int loveMessages = int.Parse(Console.ReadLine());
int roses = int.Parse(Console.ReadLine());
int keyholders = int.Parse(Console.ReadLine());
int cartoons = int.Parse(Console.ReadLine());
int luckySurprise = int.Parse(Console.ReadLine());

double loveMessagePrice = 0.60;
double rosePrice = 7.20;
double keyholderPrice = 3.60;
double cartoonPrice = 18.20;
double luckySurprisePrice = 22;

int totalItems = loveMessages + roses + keyholders + cartoons + luckySurprise;
double totalPrice = (loveMessages * loveMessagePrice) + (roses * rosePrice) + (keyholders * keyholderPrice) + (cartoons * cartoonPrice) + (luckySurprise * luckySurprisePrice);

if (totalItems > 25) totalPrice *= 0.65;

totalPrice *= 0.90;

double moneyLeft = totalPrice - partyPrice;

if (moneyLeft >= 0) Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
else Console.WriteLine($"Not enough money! {Math.Abs(moneyLeft):F2} lv needed.");
