Console.WriteLine("Compta quants \"LA\" hi ha");
Console.WriteLine();

Console.Write("Frase: ");
var frase = Console.ReadLine();
frase = frase.ToLower();
int contador = 0;

for(int i=0; i<frase.Length - 1; i++)
{
  if(frase[i] == 'l' && frase[i+1] == 'a')
  {
    contador++;
  }
}
Console.WriteLine($"\"la\" surt {contador} vegades.");