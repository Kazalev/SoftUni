double budget = double.Parse(Console.ReadLine());
int gpus = int.Parse(Console.ReadLine());
int cpus = int.Parse(Console.ReadLine());
int rams = int.Parse(Console.ReadLine());

int gpuPrice = 250;

double totalGPUPrice = gpus * gpuPrice;
double totalCPUPrice = cpus * totalGPUPrice * 0.35;
double totalRAMPrice = rams * totalGPUPrice * 0.10;

double totalItemsPrice = totalGPUPrice + totalCPUPrice + totalRAMPrice;

if (gpus > cpus)
    totalItemsPrice = totalItemsPrice - (totalItemsPrice * 0.15);

double budgetLeft = totalItemsPrice - budget;

if (budgetLeft > 0)
    Console.WriteLine($"Not enough money! You need {Math.Abs(budgetLeft):F2} leva more!");
else
    Console.WriteLine($"You have {Math.Abs(budgetLeft):F2} leva left!");
