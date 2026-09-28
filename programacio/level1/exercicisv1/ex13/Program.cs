Console.WriteLine("Calculadora");

Console.Write("Entra el primer numero: ");
var primernumero = Console.ReadLine();
Console.Write("Entra el segon numero: ");
var segonnumero = Console.ReadLine();

int fprimernumero = Convert.ToInt32(primernumero);
int fsegonnumero = Convert.ToInt32(segonnumero);

Console.WriteLine($"{primernumero} + {segonnumero} = {fprimernumero + fsegonnumero}");
Console.WriteLine($"{primernumero} - {segonnumero} = {fprimernumero - fsegonnumero}");
Console.WriteLine($"{primernumero} * {segonnumero} = {fprimernumero * fsegonnumero}");
Console.WriteLine($"{primernumero} / {segonnumero} = {fprimernumero / fsegonnumero} i en sobra {fprimernumero % fsegonnumero}");