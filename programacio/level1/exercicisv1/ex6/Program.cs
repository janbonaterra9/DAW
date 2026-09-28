Console.Write("Quant medeix el costat del teu quadrat? ");
var costat = Console.ReadLine();

int fcostat = Convert.ToInt32(costat);

Console.WriteLine($"El perimetre del teu quadrat és {fcostat * 4}");