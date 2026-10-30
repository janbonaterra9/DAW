namespace punteriaDustWater;

class Program
{
    static void Main(string[] args)
    {
        List<string> participants = ["Ringo Kill", "Dead-Eye", "Iron Will","Shadow Mac"];
        List<List<int>> puntuacions = [
            [3, 5, 4, 1],
            [4, 3, 3, 3],
            [5, 5, 5, 5],
            [2, 5, 4, 1]
        ];
        List<int> resultats = [0, 0, 0, 0];
        
        for(int i= 0; i<resultats.Count; i++)
        {
            var mesGran = CalcularElMesGran(puntuacions, i);
            var mesPetit = CalcularElMesPetit(puntuacions, i);

            resultats[i] = mesGran + mesPetit;
        }

        int guanyador = CalcularElGuanyador(resultats);
        
        


        Console.WriteLine($"El guanyador del torneig és {participants[guanyador]} amb una puntuació final de {resultats[guanyador]}");

    }

  static int CalcularElGuanyador(List<int> resultats)
  {
    int guanyador = 0;
    for(int i= 1; i<resultats.Count; i++)
        {
            if(resultats[guanyador] < resultats[i])
            {
                guanyador = i;
            }
        }
    if(HiHaEmpat(resultats, guanyador))
        {
            var mesPetit = 0;
            for(int i = 1; i<resultats.Count; i++)
            {
                if(resultats[mesPetit] > resultats[i])
                {
                    mesPetit = i;
                }
            }
            return mesPetit;
        }
    return guanyador;
  }

  static bool HiHaEmpat(List<int> resultats, int guanyador)
  {
    var contador = 0;
    for(int i=0; resultats.Count > i; i++)
        {
            if(resultats[i] == guanyador)
            {
                contador++;
            }
        }
    if(contador > 1)
        {
            return true;
        }
    return false;
  }

  static int CalcularElMesPetit(List<List<int>> puntuacions, int i)
  {
        var mesPetit = puntuacions[0][i];
        for(int j=0; j<puntuacions.Count; j++)
        {
            if(puntuacions[j][i] < mesPetit)
            {
                mesPetit = puntuacions[j][i];
            }
        }
        return mesPetit;
  }

  static int CalcularElMesGran(List<List<int>> puntuacions, int i)
    {
        var mesGran = puntuacions[0][i];
        for(int j=0; j<puntuacions.Count; j++)
        {
            if(puntuacions[j][i] > mesGran)
            {
                mesGran = puntuacions[j][i];
            }
        }
        return mesGran;
    }
}
