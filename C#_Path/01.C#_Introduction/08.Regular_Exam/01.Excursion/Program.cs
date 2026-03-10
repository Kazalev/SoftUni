int people = int.Parse(Console.ReadLine());
int nights = int.Parse(Console.ReadLine());
int trasportCards = int.Parse(Console.ReadLine());
int tickets = int.Parse(Console.ReadLine());

double pricePerNight = 20;
double pricePerTransportCard = 1.60;
double pricePerTicket = 6;

double totalPriceForNights = pricePerNight * nights;
double totalPriceForTransportCards = pricePerTransportCard * trasportCards;
double totalPriceForTickets = pricePerTicket * tickets;

double totalPrice = (totalPriceForNights + totalPriceForTransportCards + totalPriceForTickets) * people;

Console.WriteLine($"{totalPrice * 1.25:F2}");