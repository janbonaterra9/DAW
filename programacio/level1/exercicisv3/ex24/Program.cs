Console.WriteLine("La seqüència de Collatz");
Console.WriteLine();

Console.Write("Número: ");
var fnum = Console.ReadLine();
var num = Convert.ToInt32(fnum);

while(num !=1)
{
  Console.Write($"{num} ");
  if (num % 2 == 0)
  {
    num /= 2;
  } else
  {
    num = num * 3 + 1;
  }
}
Console.Write("1");