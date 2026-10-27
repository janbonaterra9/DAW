namespace examen;

class Program
{
    static void Main(string[] args)
    {
        int[][] mapa = [
          [3,4,1,9,5],
          [0,3,2,8,7],
          [7,6,3,1,8],
          [1,4,9,2,1]  
        ];
        string cords = "";

        for(int fila=0; fila<mapa.Length; fila++)
        {
            for(int col=0; col<mapa[fila].Length; col++)
            {
                if(HiHaUnSetiUnNou(mapa,fila,col))
                {
                    cords += $"{fila},{col}";
                }
            }
        }
        Console.WriteLine($"Sant Jordi ha de anar a {cords}.");

    }

  private static bool HiHaUnSetiUnNou(int[][] mapa, int fila, int col)
  {
    for(int i=0; i<mapa[fila].Length; i++)
        {
            if(mapa[fila][i] == 9 || mapa[fila][i] == 7)
            {
                for(int j=0; j<mapa.Length; j++)
                {
                    if(mapa[fila][i] == 9)
                    {
                        if(mapa[j][col] == 7)
                        {
                            return true;
                        }
                    }
                    if(mapa[fila][i] == 7)
                    {
                        if(mapa[j][col] == 9)
                        {
                            return true;
                        }
                    }
                }
            }
        }
        return false;
  }
}
