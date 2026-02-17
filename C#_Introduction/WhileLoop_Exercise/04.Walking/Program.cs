int goal = 10000;
int totalSteps = 0;

string input = Console.ReadLine();
while (input != "Going home" && totalSteps < goal)
{
    int steps = int.Parse(input);
    totalSteps += steps;

    if (totalSteps < goal) input = Console.ReadLine();
}

if (input == "Going home")
{
    int stepsToHome = int.Parse(Console.ReadLine());
    totalSteps += stepsToHome;
}

if (totalSteps >= goal)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{totalSteps - goal} steps over the goal!");
}
else
{
    Console.WriteLine($"{goal - totalSteps} more steps to reach goal.");
}