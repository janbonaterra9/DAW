using System.Net.Sockets;

Console.WriteLine("El més jove");


Console.Write("Entra el primer nom: ");
var primerNom = Console.ReadLine();
Console.Write($"Entra l'edat d'en {primerNom}: ");
var fedatPrimerNom = Console.ReadLine();
var edatPrimerNom = Convert.ToInt32(fedatPrimerNom);

Console.Write("Entra el primer nom: ");
var segonNom = Console.ReadLine();
Console.Write($"Entra l'edat d'en {segonNom}: ");
var fedatSegonNom = Console.ReadLine();
var edatSegonNom = Convert.ToInt32(fedatSegonNom);

var resposta = compararEdats();

string compararEdats()
{
  if (edatPrimerNom < edatSegonNom)
  {
    return $"En {primerNom} és més jove que en {segonNom}";
  } else if (edatSegonNom < edatPrimerNom)
  {
    return $"En {segonNom} és més jove que en {primerNom}";
  }
  return $"En {primerNom} i en {segonNom} son iguals";
}

Console.WriteLine(resposta);