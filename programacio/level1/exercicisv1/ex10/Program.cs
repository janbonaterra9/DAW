Console.Write("Digues un valor en metres: ");
var metres = Console.ReadLine();
int fmetres = Convert.ToInt32(metres);

double peus = fmetres * 3.28084;

Console.WriteLine($"{fmetres} metres són {peus} peus");