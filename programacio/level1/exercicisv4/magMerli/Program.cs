namespace magMerli;

class Program
{
    static void Main(string[] args)
    {
        string sequencia = "SBCSDEFR";
        char lletraBuscada = 'R';
        char lletraDistancia = 'S';

        int posicioLletraBuscada = BuscarLletraBuscada(sequencia, lletraBuscada);

        if(posicioLletraBuscada == -1)
        {
            Console.WriteLine("La lletra buscada no hi és a la sequencia.");
            return;
        }
        int posicioLletraDistancia = -1;

        for(int i=posicioLletraBuscada - 1; i >= 0; i--)
        {
            if(sequencia[i] == lletraDistancia)
            {
                posicioLletraDistancia = i;
                break;
            }
        }

        if(posicioLletraDistancia == -1)
        {
            Console.WriteLine($"No existeix una {lletraDistancia} anterior a la lletra buscada.");
            return;
        }

        Console.WriteLine($"La \"{lletraBuscada}\" és la posició {posicioLletraBuscada} i, mirant cap enrere, la primera \"{lletraDistancia}\" és a la posició {posicioLletraDistancia}. Per tant la seva distància és de {posicioLletraBuscada - posicioLletraDistancia}");

    }

  static int BuscarLletraBuscada(string sequencia, char lletraBuscada)
  {
    int vegades = 0;
    while (vegades < sequencia.Length)
        {
            if(sequencia[vegades] == lletraBuscada)
            {
                return vegades;
            }
            vegades++;
        }
    return -1;
  }
}
