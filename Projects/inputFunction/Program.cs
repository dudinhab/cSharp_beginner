string? inputFunction;
bool valid = false;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
do
{
    inputFunction = Console.ReadLine();
    string inputVerify = "";
    if (inputFunction != null)
    {
        inputVerify = inputFunction.Trim();
        inputFunction = inputFunction.ToLower();
    }
    if (inputVerify == "administrator" || inputVerify == "manager" || inputVerify == "user")
    {
        valid = true;
        Console.WriteLine($"Your input value ({inputFunction}) has been accepted.");
    }
    else
    {
        Console.WriteLine($"The role name that you entered, \"{inputFunction}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }
} while (!valid);