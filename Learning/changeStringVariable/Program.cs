//IndexOf é utilizado para encontrar o char inserido entre ('') e restitui a posição que esta o caracter indicado na variável string
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.LastIndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

message = "What is the value <span>between the tags</span>?";

openingPosition = message.IndexOf("<span>");
closingPosition = message.IndexOf("</span>");

openingPosition += 6;
length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


//Remove é utilizado para remover um range de caracter onde sao definidos o inicio e o fim
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);


//Replace sere para trocar um caracter por outro em toda a string, sendo indicado o caracter que deve ser trocado, e o caracter de troca
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);