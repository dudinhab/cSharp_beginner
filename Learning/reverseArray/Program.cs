string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result1 = new string(valueArray);
Console.WriteLine(result1);

//Union every element with , to do separate element in array
string result2 = String.Join(",", valueArray);
Console.WriteLine(result2);


//Split for an element with , is separate in one position in the array
string[] items = result2.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}