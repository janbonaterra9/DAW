Console.WriteLine("Generador de Contrassenyes");

Console.Write("Quin és el teu nom? ");
var nom = Console.ReadLine();

Console.Write("Quin és el teu any de naixament? ");
var any = Console.ReadLine();

Console.WriteLine($"La teva contrassenyan és: {nom + any}");