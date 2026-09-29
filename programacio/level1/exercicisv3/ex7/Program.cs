Console.WriteLine("Multiple de 10");

var resposta = "INCORRECTE";

while (resposta == "INCORRECTE")
{
  Console.Write("Entra un múltiple de 10: ");
  var fnum = Console.ReadLine();
  var num = Convert.ToInt32(fnum);

  if (num % 10 == 0)
  {
    resposta = $"CORRECTE, {fnum[0]} per 10 elevat a {fnum[1..].Length} és {fnum}";
  } 
  Console.WriteLine(resposta);
}
