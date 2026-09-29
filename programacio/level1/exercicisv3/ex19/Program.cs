Console.WriteLine("Quadrat");
Console.WriteLine();

Console.Write("Número: ");
var fnum = Console.ReadLine();
var num = Convert.ToInt32(fnum);

for(int i=1; i<=num; i++)
{

  for(int j=1; j<=num; j++)
  {
    if (i == 1 || num == i || num == j || j == 1)
    {
      Console.Write("* ");
    } else
    {
      Console.Write("  ");
    }

  }
  Console.WriteLine();
}