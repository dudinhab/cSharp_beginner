// See https://aka.ms/new-console-template for more information
// + addition  
// - subtraction 
// * multiplication
// / divisor
// % modulus indicates the remainder of the division of interger
// The order of resolution is the mathematical order
// +=, -=, *=, ++ and -- are increments formats

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32) * (5 / 9m);
Console.Write($"The temperature is {celsius} Celsius.");