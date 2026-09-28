Console.Write("Com et dius? ");
var nom = Console.ReadLine();
Console.Write("Quin any vas neixer? ");
var any = Console.ReadLine();

int fany = Convert.ToInt32(any);

Console.WriteLine($"Hola, {nom}, ja tens {DateTime.Now.Year - fany} anys!");