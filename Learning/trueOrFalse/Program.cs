/*True or false are exression for a condicional
If(condicional)
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
varible.Contains()
variable.ToLower() != variable2.ToLower()
 == != < > <= >=
*/

int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");