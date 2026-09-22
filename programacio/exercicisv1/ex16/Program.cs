// Demanar nom i cognom
Console.Write("El teu nom: ");
var nom = Console.ReadLine();
Console.Write("El teu cognom: ");
var cognom = Console.ReadLine();

// Convertir la primera lletra a majuscula i la resta a minuscula
string lowernom = nom.ToLower();
string lowercognom = cognom.ToLower();

char xnom = char.ToUpper(nom[0]);
char xcognom = char.ToUpper(cognom[0]);

// Retornar el nom complet
Console.WriteLine($"Nom complet: {xnom + lowernom[1..]} {xcognom + lowercognom[1..]}");