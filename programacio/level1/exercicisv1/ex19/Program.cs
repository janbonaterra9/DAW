Console.Write("Hora actual: ");
var horaActual = Console.ReadLine();
Console.Write("Hores a incrementar: ");
var horaIncrementada = Console.ReadLine();

int fhoraActual = Convert.ToInt32(horaActual);
int fhoraIncrementada = Convert.ToInt32(horaIncrementada);

int horaTotal = fhoraActual + fhoraIncrementada;

if (horaTotal > 12 && horaTotal < 24)
{
  horaTotal = horaTotal - 12;
} 

Console.WriteLine($"D'aqui a {horaIncrementada} hores seran les {horaTotal}");