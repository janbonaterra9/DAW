namespace laMinaDryDust;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            
        Console.Write("Quants barrils hi ha? ");
        var fbarrils = Console.ReadLine();
        if(fbarrils == null)
        {
            Console.WriteLine("ERROR.No has escrit res!");
            return;
        }
        var barrils = Convert.ToInt32(fbarrils);

        Console.Write("Introdueix la quantitat de pólvora de cada barril separat per espais: ");
        var fpolvoraLlista = Console.ReadLine();
        if(fpolvoraLlista == null)
        {
            Console.WriteLine("ERROR. No has escrit res!");
            return;
        }
        var fpolvoraArray = fpolvoraLlista.Split(" ");

        int[] polvoraArray = new int[fpolvoraArray.Length];

        for(int i=0; fpolvoraArray.Length > i; i++)
        {
            polvoraArray[i] = Convert.ToInt32(fpolvoraArray[i]);
        }


        string llistaInicial = LlistaInicial(barrils, polvoraArray);

        Console.WriteLine($"{llistaInicial}");

        int mesGran =  CalcularElMesGran(polvoraArray);
        
        int torns = 0;
        while (mesGran > torns)
        {
            var restar = RestarUnACadaBarril(polvoraArray);
            Console.WriteLine($"Torn {torns + 1}: {restar}");
            torns++;
        }
        

        Console.WriteLine();
        Console.WriteLine("Tots els barrils estan buits!");
        Console.WriteLine($"S'han necessitat {torns} torns.");
        } catch(Exception)
        {
            Console.WriteLine("ERROR. Entra bé les dades!!");
        }

    }

  private static string RestarUnACadaBarril(int[] llistaInicial)
  {
    string restat = "[";
    for(int i=0; llistaInicial.Length > i; i++)
        {
            if (llistaInicial[i] > 0)
            {
                llistaInicial[i]--;
                if(i != llistaInicial.Length - 1)
                {
                    restat += $"{llistaInicial[i]}, ";
                } else
                {
                    restat += $"{llistaInicial[i]}]";
                }

            } else
            {
                if(i != llistaInicial.Length - 1)
                {
                    restat += $"{llistaInicial[i]}, ";
                } else
                {
                    restat += $"{llistaInicial[i]}]";
                }
            }
        }
    return restat;
  }

  private static int CalcularElMesGran(int[] polvoraArray)
  {
    var mesGran = polvoraArray[0];
    for(int i=1; polvoraArray.Length>i; i++)
        {
            if(polvoraArray[i] > mesGran)
            {
                mesGran = polvoraArray[i];
            }
        }
    return mesGran;
  }

  private static string LlistaInicial(int barrils, int[] polvoraArray)
  {
    string llistaInicial = "Llista inicial: [";
        for(int i=0; barrils > i; i++)
        {
            if (i != barrils - 1)
            {
                llistaInicial += $"{polvoraArray[i]}, ";
            } else
            {
                llistaInicial += polvoraArray[i];
            }
        }
    llistaInicial += "]";
    return llistaInicial;
  }
}
