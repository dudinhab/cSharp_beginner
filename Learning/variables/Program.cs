// See https://aka.ms/new-console-template for more information
//For a string, need insert value between double quotes
string firstName = "Duda";

// when use a float, insert F after number
// when use a decimal, insert m after number
// when don't have indetification, automatically is double
int age = 26;
decimal temperature = 19.5m;

//For boolean value need insert just true or false
bool isRaining = true;

Console.Write("Hello, ");
Console.Write(firstName);
Console.WriteLine("!");
Console.Write("You are ");
Console.Write(age);
Console.WriteLine(" years old!");
Console.Write("Now is ");
Console.Write(temperature);
Console.Write("° celsius. And is raining? ");
Console.WriteLine(isRaining);

int result = 10%3;
Console.WriteLine(result);

string name = "Alice";
Console.WriteLine($"My name is {name} and I'm {age} years old.");