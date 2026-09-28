Console.WriteLine("Creador de adreçes electroniques:");

Console.Write("Escriu el teu usuari:");
var usuari = Console.ReadLine();
Console.Write("Escriu el teu domini: ");
var domini = Console.ReadLine();

Console.WriteLine($"La teva adreça electronica serà: {usuari + "@" + domini}");