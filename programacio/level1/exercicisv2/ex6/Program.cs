Console.Write("Usuari: ");
var usuari = Console.ReadLine();


if (usuari == "admin" || usuari == "administrador")
{
  Console.WriteLine("Benvingut al sistema");
} else
{
  Console.Write("Contrassenya: ");
  Console.ReadLine();
  Console.WriteLine("Benvolgut al sistema");
}

