int age = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

int toyCount = 0;
double money = 0;
double evenBirthdayMoney = 10;

for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0)
    {
        money = money + evenBirthdayMoney - 1;
        evenBirthdayMoney = evenBirthdayMoney + 10;
    }
    else
    {
        toyCount++;
    }
}

money = money + toyCount * toyPrice;

if (money >= washingMachinePrice) Console.WriteLine($"Yes! {money - washingMachinePrice:F2}");
else Console.WriteLine($"No! {washingMachinePrice - money:F2}");
