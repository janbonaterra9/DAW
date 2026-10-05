Console.WriteLine("Girador de paraules");
Console.WriteLine();

Console.Write("Entrada: ");
var frase = Console.ReadLine();

var paraules = frase.Split(' ');

Console.Write("Sortida: ");
for(int i=paraules.Length - 1; i >= 0; i--)
{
  Console.Write($"{paraules[i]} ");
}