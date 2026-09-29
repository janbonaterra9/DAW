Console.WriteLine("Les paraules que comencen per a");

Console.Write("Frase: ");
var frase = Console.ReadLine();
var paraules = frase.Split(' ');
int suma = 0;

for(int i=0; i < paraules.Length; i++)
{
  if (paraules[i].StartsWith("a"))
  {
    suma++;
  }
}
Console.WriteLine($"Hi ha {suma} paraules que començen per a");