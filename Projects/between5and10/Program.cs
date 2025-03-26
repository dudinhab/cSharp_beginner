string? inputNumber;
bool valid = false;
Console.WriteLine("Please input a number between 5 and 10:");
do
{
    inputNumber = Console.ReadLine();
    int numberVerify = Convert.ToInt32(inputNumber);
    if ((numberVerify > 5) && (numberVerify < 10))
    {
        Console.WriteLine($"Your input value({numberVerify}) has been accepted.");
        valid = true;
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again.");
    }
} while (!valid);
