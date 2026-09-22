Console.Write("Escriu la teva paraula:");
var paraula = Console.ReadLine();

var lparaula = paraula.Length;

Console.WriteLine($"Resultat: {paraula[0]}  {paraula[lparaula / 2]}  {paraula[lparaula - 1]}");