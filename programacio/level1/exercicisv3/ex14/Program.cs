Console.WriteLine("Elimina lletres");

Console.Write("Frase: ");
var frase = Console.ReadLine();
var fraseFinal = "";
for(int i=0; i<frase.Length; i++)
{
  if(frase[i] != 'u' && frase[i] != 's' && frase[i] != 'a')
  {
    fraseFinal += frase[i];
  }
}
Console.WriteLine(fraseFinal);