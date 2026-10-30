namespace dracGolafre;

class Program
{
    static void Main(string[] args)
    {
        List<List<int>> mapa = [
            [2, 5, 6, 8, 3],
            [9, 6, 7, 4, 6],
            [0, 3, 1, 5, 9],
            [4, 6, 7, 9, 9],
            [5, 6, 4, 8, 7]
        ];
        List<int> posicio = [2,0];
        while(HiHanPobles(mapa, posicio)){}
    }

  static bool HiHanPobles(List<List<int>> mapa, List<int> posicio)
  {
    if((posicio[0] == 0 && posicio[1] == 0) || (posicio[0] == 0 && posicio[1] == mapa[0].Count) ..)
  }

  static
}
