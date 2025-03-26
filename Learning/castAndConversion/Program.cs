//When use string for riceve an int, the cast is automatic, but when use int isn't automatic
//Cast implicit
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

//cast explicit
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

//ToString convertion - to String
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);
//Convert
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

//Parse convertion - to Number
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

//When use convert the convertion is rounded


string value = "bad";
int result = 0;
//Try parse try convert a variable, after insert in variable out, and return bool in method
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result}");