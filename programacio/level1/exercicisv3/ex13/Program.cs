Console.WriteLine("Gira la frase");

Console.Write("Frase: ");
string frase = Console.ReadLine();
string fraseFinal = "";

for(int i=frase.Length-1; i>=0; i--)
{
  fraseFinal += frase[i] ;
}
Console.WriteLine(fraseFinal);