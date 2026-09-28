Console.WriteLine("El número més gran");

Console.Write("Entra el número 1: ");
var fnum1 = Console.ReadLine();
var num1 = Convert.ToInt32(fnum1);

Console.Write("Entra el número 2: ");
var fnum2 = Console.ReadLine();
var num2 = Convert.ToInt32(fnum2);

Console.Write("Entra el número 3: ");
var fnum3 = Console.ReadLine();
var num3 = Convert.ToInt32(fnum3);

Console.Write("Entra el número 4: ");
var fnum4 = Console.ReadLine();
var num4 = Convert.ToInt32(fnum4);

Console.Write("Entra el número 5: ");
var fnum5 = Console.ReadLine();
var num5 = Convert.ToInt32(fnum5);

int gran = num1;
var resultat = calcularNumero(num1, num2, num3, num4, num5, gran);

string calcularNumero(int num1, int num2, int num3, int num4, int num5, int gran)
{
  if (num2 > gran)
  {
    gran = num2;
  }
  if (num3 > gran)
  {
    gran = num3;
  }
  if (num4 > gran)
  {
    gran = num4;
  }
  if (num5 > gran)
  {
    gran = num5;
  }

  return $"El número més gran és {gran}";
}

Console.WriteLine(resultat);