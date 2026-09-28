Console.Write("Numero 1: ");
var fnum1 = Console.ReadLine();
var num1 = Convert.ToInt32(fnum1);
Console.Write("Numero 2: ");
var fnum2 = Console.ReadLine();
var num2 = Convert.ToInt32(fnum2);
Console.Write("Numero 3: ");
var fnum3 = Console.ReadLine();
var num3 = Convert.ToInt32(fnum3);


var resultat = ordenarNumeros(num1, num2, num3);

Console.WriteLine(resultat);

string ordenarNumeros(int num1, int num2, int num3)
{
  if (num1 < num2 && num2 < num3)
  {
    return $"{num1} {num2} {num3}";
  }
  else
  {
    if (num1 < num3 && num3 < num2)
    {
      return $"{num1} {num3} {num2}";
    }
    else
    {
      if (num2 < num1 && num1 < num3)
      {
        return $"{num2} {num1} {num3}";
      }
      else
      {
        if (num2 < num3 && num3 < num1)
        {
          return $"{num2} {num3} {num1}";
        }
        else
        {
          if (num3 < num2 && num2 < num1)
          {
            return $"{num3} {num2} {num1}";
          }
        }
      }
    }
  }
  return $"{num3} {num1} {num2}";
}

