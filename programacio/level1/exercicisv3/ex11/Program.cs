Console.WriteLine("El triangle");

Console.Write("Número: ");
var fnum = Console.ReadLine();
var num = Convert.ToInt32(fnum);

for(int i=1; num>=i; i++)
{
  for(int j=1; i>=j ; j++)
  {
    Console.Write("* ");
  }
  Console.WriteLine();
}