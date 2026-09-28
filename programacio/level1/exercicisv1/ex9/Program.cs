Console.Write("Introdueix una cantitat de minuts: ");
var minutsTotals = Console.ReadLine();
int fminutsTotals = Convert.ToInt32(minutsTotals);

int hores = fminutsTotals / 60;
int minuts = fminutsTotals % 60;

Console.WriteLine($"{fminutsTotals} minuts son {hores}h i {minuts}min.");
