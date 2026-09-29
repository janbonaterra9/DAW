Console.WriteLine("Suma de nombres");

Console.Write("Número: ");
var fnum = Console.ReadLine();
var num = Convert.ToInt32(fnum);
int suma = 0;

for(int i=0; num >= i; i++)
{
  suma = suma + i;
}
Console.WriteLine($"La suma és {suma}");
