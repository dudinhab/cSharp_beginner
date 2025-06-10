string permission = "Manager";
int level = 19;

if (permission == "Admin")
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else
{
    if (level >= 20)
    {
        if (permission == "Manager")
        {
            Console.WriteLine("Contact an Admin for access.");
        }
        else
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}