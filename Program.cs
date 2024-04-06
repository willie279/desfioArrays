// desafio de inversion de palabras de una oracion. 
Console.Clear();
string pangram = "The quick brown fox jump over the lazy dog"; // Necesito recorrer cada palabra
string[] subPangram = pangram.Split(' ');
string[] newPangram = new string[subPangram.Length]; // Crea una nueva cadena de la misma longitud que subPangram
//Console.WriteLine(newPangram.Length);
for (int i = 0; i < subPangram.Length; i++)
{
    char[] message = subPangram[i].ToCharArray();
    Array.Reverse(message);
    // Console.WriteLine(message);// validar recorrido del codigo

    newPangram[i] = new string(message);

}
string newMessage = string.Join(" ", newPangram);
Console.WriteLine(newMessage);
// otro metodo
string reverse = "The quick brown fox jump over the lazy dog"; // Necesito recorrer cada palabra
var wordOfList = reverse.Split(" ");
foreach (var word in wordOfList)
{
    var newWords = word.ToCharArray();// pregunta a luis. sobre no necesitar el foreach
    Array.Reverse(newWords);
    Console.Write(newWords);
    Console.Write(' ');
}


// Desafio para analizar una cadena de pedidos. 
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179,A32";
Console.WriteLine(" ");
Console.WriteLine("sorted...");
string[] orderIds = orderStream.Split(",");
Array.Sort(orderIds);
foreach (var Ids in orderIds)
{
    if (Ids.Length == 4)
    {
        Console.WriteLine(Ids);

    }
    else
    {
        Console.WriteLine($"{Ids} \t --- Error");
    }

}
