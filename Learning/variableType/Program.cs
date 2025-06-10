Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");


Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

//When the word new is used to create a new instance of an object, this is stored in memory via Heap
/*
int per la maggior parte dei numeri interi
decimal per i numeri che rappresentano importi in denaro
bool per i valori true o false
string per un valore alfanumerico
byte: per lavorare con dati codificati provenienti da altri sistemi informatici o che usano set di caratteri diversi.
double: per l'uso in ambito geometrico o scientifico. double viene usato di frequente quando si creano giochi basati sul movimento.
System.DateTime: per un valore di data e ora specifico.
System.TimeSpan: per un intervallo di anni/mesi/giorni/ore/minuti/secondi/millisecondi.
*/