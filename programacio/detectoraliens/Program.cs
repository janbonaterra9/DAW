Console.Write("Quina és la temperatura de l'alien? ");
var temperatura = Console.ReadLine();
var ftemperatura = Convert.ToDouble(temperatura);
Console.Write("Quants cafès s'ha pres l'alien? ");
var cafes = Console.ReadLine();
var fcafes = Convert.ToInt32(cafes);


var resultat = DeterminaSiEntren(ftemperatura, fcafes);
Console.WriteLine(resultat);


string DeterminaSiEntren(double ftemperatura, int fcafes)
{
  if (ftemperatura > 37.5 || fcafes > 5)
  {
    return "ALERTA: Àlien detectat! Tanqueu les comportes!";
  }
  return "Accés permès. Bon dia, humà.";  
}