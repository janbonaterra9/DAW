namespace gira;

public class Program
{
  public static void Main(string[] args)
  {
    Console.Write("Numero: ");
    var numero = Console.ReadLine();



    string resultat = girarNumero(numero);



    Console.WriteLine(resultat);
  }

  public static string girarNumero(string? numero)
  {
    var resultat = "";

    if (numero.Length == 1)
    {
      return numero;
    }

    resultat = numero;

    var nouNumero = giraLaXifra(numero);
    
    while(nouNumero != numero)
    {
      resultat += $", {nouNumero}";
      nouNumero = giraLaXifra(nouNumero);

    }

    



    return resultat;
  }

  public static object giraLaXifra(object numero)
  {
    var nouNumero = "";

    for(int i=1; i < numero.Length; i++)
    {
      nouNumero = $"{numero[i]}"
    }
    return $"{nouNumero} {numero[0]}"
  }
}