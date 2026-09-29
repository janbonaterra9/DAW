Console.WriteLine("Estadística de lletres");
Console.WriteLine();

Console.Write("Text: ");
var ftext = Console.ReadLine();
var text = ftext.ToLower();

var contadorA = 0;
var contadorE= 0;
var contadorI = 0;
var contadorO = 0;
var contadorU = 0;


for (int i=0; i<text.Length; i++)
{
  if(text[i] == 'a' || text[i] == 'à' || text[i] == 'á')
  {
    contadorA++;
  }
  if(text[i] == 'e' || text[i] == 'è' || text[i] == 'é')
  {
    contadorE++;
  }
  if(text[i] == 'i' || text[i] == 'ì' || text[i] == 'í')
  {
    contadorI++;
  }
  if(text[i] == 'o' || text[i] == 'ò' || text[i] == 'ó')
  {
    contadorO++;
  }
  if(text[i] == 'u' || text[i] == 'ù' || text[i] == 'ú')
  {
    contadorU++;
  }
}
Console.WriteLine($"A: {contadorA}");
Console.WriteLine($"E: {contadorE}");
Console.WriteLine($"I: {contadorI}");
Console.WriteLine($"O: {contadorO}");
Console.WriteLine($"U: {contadorU}");