Console.WriteLine("Qui la te més llarga?");
Console.Write("Entra una paraula: ");
var paraula1 = Console.ReadLine();
Console.Write("Entra una paraula: ");
var paraula2 = Console.ReadLine();
Console.Write("Entra una paraula: ");
var paraula3 = Console.ReadLine();

var lparaula1 = paraula1.Length;
var lparaula2 = paraula2.Length;
var lparaula3 = paraula3.Length;

var resposta = quiLaTeMesLlarga();

string quiLaTeMesLlarga()
{
  if (lparaula1 > lparaula2 && lparaula1 > lparaula3)
  {
    return $"La paraula més llarga és {paraula1}";
  } else if (lparaula2 > lparaula1 && lparaula2 > lparaula3)
  {
    return $"La paraula més llarga és {paraula2}";
  }
  return $"La paraula més llarga és {paraula3}";
}

Console.WriteLine(resposta);