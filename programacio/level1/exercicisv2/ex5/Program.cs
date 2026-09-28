Console.Write("Entra el numero: ");
var fnum = Console.ReadLine();
var num = Convert.ToInt32(fnum);

var resposta = calcularParellOSenar(num);

string calcularParellOSenar(int num)
{
  if((num % 2) == 1)
  {
    return "El numero es senar";
  }
  return "El numero és parell";
}



Console.WriteLine(resposta);