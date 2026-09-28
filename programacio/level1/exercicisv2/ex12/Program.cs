Console.WriteLine("El casal d'estiu");
Console.Write("Entra el número: ");
var fnumero = Console.ReadLine();
var numero = Convert.ToInt32(fnumero);

var resultat = clasificarGrups();

string clasificarGrups()
{
  if (numero >= 1 && numero <= 20)
  {
    return "Va al grup vermell";
  } else if (numero >= 21 && numero <= 40)
  {
    return "Va al grup blau";
  } else if (numero >= 41 && numero <= 60)
  {
    return "Va al grup verd";
  }
  return "Va al grup blanc";
}

Console.WriteLine(resultat);