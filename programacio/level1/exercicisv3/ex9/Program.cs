Console.WriteLine("Compta les vocals");


Console.Write("Frase sense accents: ");
var frase = Console.ReadLine();
var sumaVocals = 0;

for(int i=0; frase.Length > i; i++ )
{
  if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u' )
  {
    sumaVocals++;
  }
}
Console.WriteLine($"La frase té {sumaVocals} vocals.");