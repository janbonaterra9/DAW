namespace gira;

public class Program
{
  public static void Main(string[] args)
  {
    try
    {
      
    Console.Write("Numero: ");
    var numero = Console.ReadLine();



    var resultat = GirarNumero(numero);



    Console.WriteLine(resultat);
    } 
    catch(IndexOutOfRangeException)
    {
      Console.WriteLine("Tens que introduir un numero");
    }
  }

  public static string GirarNumero(string numero)
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

  public static string giraLaXifra(string numero)
  {
    var nouNumero = "";

    for(int i=1; i < numero.Length; i++)
    {
      nouNumero = $"{numero[i]}";
    }
    return $"{nouNumero} {numero[0]}";
  }
}