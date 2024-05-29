//class Random to generate pseudo-random #
//declare Random variable dice - create new instance (object) using its constructor
Random dice = new();
//declare int variable 'roll' - use method on Random called Next() to generate a random integer - pass in parameters that is greater than or = to 1 and less than 7
int roll = dice.Next(1,7);
//class Console WriteLine() method to print to console
Console.WriteLine(roll);
//=============================================================
//overloaded method example - using .Next() with no boundary, max boundary and between
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

dice.Next(0);
//=============================================================
int firstValue = 500;
int secondValue = 600;

int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);