//Uso de las bibliotecas .NET
//System.Random and System.Console

//in actual versions of .NET, you can use Random dice = new(); instead of Random dice = new Random();
//Random dice = new Random();
Random dice = new();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

//overload versions of the Next method
int roll1 = dice.Next();        // 0 to 2,147,483,647
int roll2 = dice.Next(101);     // 0 to 100
int roll3 = dice.Next(50, 101); // 50 to 100

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

//Math class
Console.WriteLine("----- Using the Math class -----");
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);