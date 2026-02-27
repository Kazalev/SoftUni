int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

int a = start / 1000;
int b = (start / 100) % 10;
int c = (start / 10) % 10;
int d = start % 10;

int e = end / 1000;
int f = (end / 100) % 10;
int g = (end / 10) % 10;
int h = end % 10;

for (int i = a; i <= e; i++)
{
    if (i % 2 == 0) continue;

    for (int j = b; j <= f; j++)
    {
        if (j % 2 == 0) continue;

        for (int x = c; x <= g; x++)
        {
            if (x % 2 == 0) continue;

            for (int y = d; y <= h; y++)
            {
                if (y % 2 == 0) continue;

                Console.Write($"{i}{j}{x}{y} ");
            }
        }
    }
}