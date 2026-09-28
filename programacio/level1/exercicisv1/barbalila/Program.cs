Console.Write("Nombre de pirates: ");
var pirates = Console.ReadLine();
Console.Write("Nombre de monedes d'or: ");
var monedes = Console.ReadLine();

int fpirates = Convert.ToInt32(pirates);
int fmonedes = Convert.ToInt32(monedes);


Console.WriteLine($"Cada pirata reberà {fmonedes / fpirates} i el capità {fmonedes % fpirates} monedes extres.");