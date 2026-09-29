Console.WriteLine("Tira el dau.");

var punts = 0;
var vegades = 1;
Random r = new Random();

while (punts < 100)
{
  var valor = r.Next(1,7);
  Console.Write("Tira el dau: ");
  Console.WriteLine(valor);
  punts = punts + valor;
  vegades++;
}

Console.WriteLine($"He hagut de tirar el dau {vegades} vegades.");