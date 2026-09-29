Console.WriteLine("Histogràma");
Console.WriteLine();

Console.WriteLine("Entreu números, entreu el zero per acabar:");
var resposta = 1;
var positius = 0;
var negatius = 0;

while (resposta != 0)
{
  var fresposta = Console.ReadLine();
  resposta = Convert.ToInt32(fresposta);

  if(resposta > 0)
  {
    positius++;
  } else if ( resposta < 0)
  {
    negatius++;
  }
}

Console.Write("Positius: ");
for(int i=0; i<positius; i++)
{
  Console.Write("*");
}
Console.WriteLine();
Console.Write("Negatius: ");
for(int j=0; j<negatius; j++)
{
  Console.Write("*");
}