namespace startrekAliens;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Spanish Star Trek: Salvant els àliens");
        Console.WriteLine();

        Console.Write("Entra l'ADN alterat de l'alien separat per espais: ");
        var llistaADN = Console.ReadLine();
        if(llistaADN == null)
        {
            Console.WriteLine("ERROR. No has entrat res capullo!!");
            return;
        }
        var arrayADN = llistaADN.Split(" ");
        int[] adn = new int[arrayADN.Length];

        for (int i=0; arrayADN.Length > i; i++)
        {
            adn[i] = Convert.ToInt32(arrayADN[i].Trim());
        }

        int hosties = ComprovarLesHostiesQueNecessiten(adn);

        if (hosties == 0)
        {
            Console.WriteLine("L'ADN ja és ascendent, no cal cap hostia.");
            return;
        }
        Console.WriteLine($"Els aliens necessiten {hosties} hosties per tenir l'ADN correcte");

    }

  private static int ComprovarLesHostiesQueNecessiten(int[] adn)
  {
    int hosties = 0;
    for(int i=1;adn.Length>i;i++)
        {
            if(adn[i]<adn[i-1])
            {
                hosties += adn[i-1] - adn[i];
                adn[i] = adn[i-1];
            }
        }
    return hosties;
  }
}
