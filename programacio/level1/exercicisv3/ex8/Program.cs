Console.WriteLine("Suma de digits");

Console.Write("Número: ");
var num = Console.ReadLine();
int voltes = 0;
int suma = 0;



for (int i=1; num.Length >= i; i++)
{
  var intnum = Convert.ToInt32(num[voltes]);
  suma =+ intnum;
  voltes++;
}

Console.WriteLine(suma);