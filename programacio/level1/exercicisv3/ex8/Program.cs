Console.WriteLine("Suma de digits");

Console.Write("Número: ");
var num = Console.ReadLine();
int suma = 0;



for (int i=0; num.Length > i; i++)
{
  var intnum = Convert.ToInt32(num[i].ToString());
  suma += intnum;
}

Console.WriteLine(suma);