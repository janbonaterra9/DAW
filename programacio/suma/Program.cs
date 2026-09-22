Console.Write("Primer numero:");
var primernumero = Console.ReadLine();
int fprimernumero = Convert.ToInt32(primernumero);
Console.Write("Segon numero:");
var segonnumero = Console.ReadLine();

int fsegonnumero;
var esCorrecte = int.TryParse(segonnumero, out fsegonnumero);
if (!esCorrecte) {
  Console.WriteLine("No és un número");
  return;
}


Console.Write($"Resultat: {fprimernumero + fsegonnumero}");
