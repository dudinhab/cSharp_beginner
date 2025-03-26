string pangram = "The quick brown fox jumps over the lazy dog";
//Cada elemento do array é identificado pelo espaço vazio
string[] pangramArray = pangram.Split(' ');
foreach (var item in pangramArray)
{
    //Transformação de cada letra em uma posição de array
    char[] wordInvert = item.ToCharArray();
    //Reverter todas as letras/posições do Array
    Array.Reverse(wordInvert);
    Console.Write(wordInvert);
    Console.Write(" ");
}