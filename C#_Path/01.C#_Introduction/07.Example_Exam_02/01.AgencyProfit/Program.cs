string airline = Console.ReadLine();
int soldAdultTickets = int.Parse(Console.ReadLine());
int soldKidTickets = int.Parse(Console.ReadLine());
double ticketPriceForAdult = double.Parse(Console.ReadLine());
double serviceTax = double.Parse(Console.ReadLine());

double ticketPriceForKid = ticketPriceForAdult * 0.3;
double ticketPriceForAdultWithTax = ticketPriceForAdult + serviceTax;
double ticketPriceForKidWithTax = ticketPriceForKid + serviceTax;


double totalProfit = (soldAdultTickets * ticketPriceForAdultWithTax) + (soldKidTickets * ticketPriceForKidWithTax);
double finalProfit = totalProfit * 0.2;

Console.WriteLine($"The profit of your agency from {airline} tickets is {finalProfit:F2} lv.");