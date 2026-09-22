Console.Write("Digues la teva primera nota: ");
var primeranota = Console.ReadLine();
int fprimeranota = Convert.ToInt32(primeranota);

Console.Write("Digues la teva segona nota: ");
var segonanota = Console.ReadLine();
int fsegonanota = Convert.ToInt32(segonanota);

Console.Write("Digues la teva tercera nota: ");
var terceranota = Console.ReadLine();
int fterceranota = Convert.ToInt32(terceranota);

Console.Write($"La teva mitjana és {(fprimeranota + fsegonanota + fterceranota) / 3}");
