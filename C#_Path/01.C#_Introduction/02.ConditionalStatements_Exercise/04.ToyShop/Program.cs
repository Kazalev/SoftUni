double puzzlePrice = 2.60;
double dollPrice = 3;
double tedyBearPrice = 4.10;
double minionPrice = 8.20;
double truckPrice = 2;

double tripPrice = double.Parse(Console.ReadLine());
int puzzles = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int tedyBears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());


int totalItems = puzzles + dolls + tedyBears + minions + trucks;
double totalPrice = (puzzles * puzzlePrice) + (dolls * dollPrice) + (tedyBears * tedyBearPrice) + (minions * minionPrice) + (trucks * truckPrice);

if (totalItems >= 50)
    totalPrice = totalPrice - (totalPrice * 0.25);

totalPrice = totalPrice - (totalPrice * 0.10);

double moneyLeft = totalPrice - tripPrice;

if (moneyLeft >= 0)
    Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
else
    Console.WriteLine($"Not enough money! {Math.Abs(moneyLeft):F2} lv needed.");

