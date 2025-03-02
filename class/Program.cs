//Random is a class, and "new Random()" create an object
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
