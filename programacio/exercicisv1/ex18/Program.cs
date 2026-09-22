Console.Write("Numero lleig: ");
var numLleig = Console.ReadLine();

double fnumLleig = Convert.ToDouble(numLleig);

int num = (int)fnumLleig;

Console.WriteLine($"Numero meravellos: {fnumLleig - num:F2}");