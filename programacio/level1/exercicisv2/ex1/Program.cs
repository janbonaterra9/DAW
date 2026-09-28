Console.Write("Entra la teva nota: ");
var fnota = Console.ReadLine();
var nota = Convert.ToInt32(fnota);

var resultat = comprovarAprovat(nota);

Console.WriteLine(resultat);

string comprovarAprovat(int nota)
{
  if (nota >= 5)
  {
    return "Has aprovat";
  }
  return "No has aprovat";
}