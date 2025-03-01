// See https://aka.ms/new-console-template for more information
string firstName = "Duda";
int age = 26;
decimal temperature = 19.5m;
bool isRaining = true;

//The concat can do with $ and between {} need insert variable name
Console.WriteLine($"Hello, {firstName}!");
//When start with @, the format text is equals writed
//You can use + for insert variable together string text
Console.WriteLine(@"You are " + age + " years old!");
//When start with @ and $, you can do both
Console.Write(@$"Now is {temperature}° celsius. And is raining? {isRaining}");