Console.WriteLine("Temps de viatge");
Console.WriteLine();

int duradaTotal = 0;

for(int i=0; i>=0; i++)
{
  Console.Write("Durada del tram: ");
  var fdurada = Console.ReadLine();
  var durada = Convert.ToInt32(fdurada);

  if(durada < 0)
  {
    break;
  } else
  {
  duradaTotal += durada;
  }
}
Console.WriteLine($"El viatge ha durat {duradaTotal / 60}:{duradaTotal % 60} hores");