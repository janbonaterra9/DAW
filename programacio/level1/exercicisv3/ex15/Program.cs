Console.WriteLine("Número: ");
var fnum = Console.ReadLine();
var num = Convert.ToInt32(fnum);

for (int i=0; i<10; i++)
{
  Console.WriteLine($"{num} x {i + 1} = {num * (i+1)}");
}
