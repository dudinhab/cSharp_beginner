string[] values = { "12,3", "45", "ABC", "11", "DEF" };
decimal sumNumber = 0m;
string sumString = "";
foreach (string value in values)
{
    decimal agreeNumber;
    if (decimal.TryParse(value, out agreeNumber))
    {
        sumNumber += agreeNumber;
    }
    else
    {
        sumString += value;
    }
}

Console.WriteLine($"Sum number: {sumNumber}");

Console.WriteLine($"Sum string: {sumString}");

