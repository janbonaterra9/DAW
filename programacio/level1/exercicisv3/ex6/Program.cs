Console.WriteLine("El numero més gran");

Console.Write("Quants nombres hi haura? ");
var fnombres = Console.ReadLine();
var nombres = Convert.ToInt32(fnombres);
int gran = -999999;

for (int i= 0; nombres> i; i++)
{
  Console.Write("Número: ");
  var fnum = Console.ReadLine();
  var num  = Convert.ToInt32(fnum);

  if (num > gran)
  {
    gran = num;
  }
}
Console.WriteLine($"El número més gran és el {gran}");