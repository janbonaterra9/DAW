Console.WriteLine("El més proper");

Console.Write("Entra el número 1: ");
var fnum1 = Console.ReadLine();
var num1 = Convert.ToInt32(fnum1);

Console.Write("Entra el número 1: ");
var fnum2 = Console.ReadLine();
var num2 = Convert.ToInt32(fnum2);

Console.Write("Entra el número 1: ");
var fnum3 = Console.ReadLine();
var num3 = Convert.ToInt32(fnum3);

var diferencia1 = Math.Abs(num1 - num2);
var diferencia2 = Math.Abs(num1 - num3);

if (diferencia1 < diferencia2)
{
  Console.WriteLine($"El numero més proper a {num1} és  el {num2}");
} else if (diferencia2 < diferencia1)
{
  Console.WriteLine($"El numero més proper a {num1} és  el {num3}");
} else {
  Console.WriteLine($"Tots dos números són igual de propers a {num1}");
}