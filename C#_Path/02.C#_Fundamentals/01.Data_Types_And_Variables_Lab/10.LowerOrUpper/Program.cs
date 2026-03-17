char character = char.Parse(Console.ReadLine());

uint charNumber = (uint)character;

if (charNumber >= 65 && charNumber <= 90) Console.WriteLine("upper-case");
else Console.WriteLine("lower-case");