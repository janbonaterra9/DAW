Console.Write("Quants carros ha de preparar? ");
var carros = Console.ReadLine();
Console.Write("Quin és el preu d'una ferradura? ");
var ferradura = Console.ReadLine();
Console.Write("Quin és el preu d'un sac de menjar? ");
var sac = Console.ReadLine();

int fCarros = Convert.ToInt32(carros);
int fFerradura = Convert.ToInt32(ferradura);
int fSac = Convert.ToInt32(sac);

int totalFerradura = fFerradura * 4;
int totalSac = fSac * 2;

Console.WriteLine($"Cost total de preparar els carros: {(totalFerradura + totalSac) * fCarros}");
