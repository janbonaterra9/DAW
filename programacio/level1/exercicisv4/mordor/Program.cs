namespace mordor;

class Program
{
    static void Main(string[] args)
    {
        List<List<int>> mapa = [
            [2, 4, 1, 8],
            [3, 1, 5, 6],
            [4, 5, 4, 4]
        ];

        List<List<int>> zonesPerilloses = [
            [0, 0, 0, 0],
            [0, 0, 0, 0],
            [0, 0, 0, 0]
        ];

        ComprovarZonesPerilloses(mapa, zonesPerilloses);

        for (int i = 0; i < mapa.Count; i++)
        {
            for (int j = 0; j < mapa[i].Count; j++)
            {
                Console.Write($"{zonesPerilloses[i][j]} ");
            }

            Console.WriteLine();
        }

        List<int> forques = ComprovarForques(zonesPerilloses);

        Console.WriteLine($"Forques: fila {forques[0] + 1}, columna {forques[1] +1}");
    }

    private static void ComprovarZonesPerilloses(List<List<int>> mapa, List<List<int>> zonesPerilloses)
    {
        for (int fila = 0; fila < mapa.Count; fila++)
        {
            for (int col = 0; col < mapa[fila].Count; col++)
            {
                if (mapa[fila][col] < MitjanaFila(mapa, fila) && mapa[fila][col] < MitjanaCol(mapa, col))
                {
                    zonesPerilloses[fila][col] = 1;
                }
            }
        }
    }

    private static double MitjanaFila(List<List<int>> mapa, int fila)
    {
        int suma = 0;

        for (int i = 0; i < mapa[fila].Count; i++)
        {
            suma += mapa[fila][i];
        }

        return (double)suma / mapa[fila].Count;
    }

    private static double MitjanaCol(List<List<int>> mapa, int col)
    {
        int suma = 0;

        for (int i = 0; i < mapa.Count; i++)
        {
            suma += mapa[i][col];
        }

        return (double)suma / mapa.Count;
    }

    private static List<int> ComprovarForques(List<List<int>> zonesPerilloses)
    {
        int filaForques = -1;
        int colForques = -1;
        int mesGran = -1;

        for (int fila = 0; fila < zonesPerilloses.Count; fila++)
        {
            for (int col = 0; col < zonesPerilloses[fila].Count; col++)
            {
                if (zonesPerilloses[fila][col] == 1)
                {
                    int contador = BuscaZonesPerillosesForca(
                        zonesPerilloses, fila, col);

                    if (contador >= mesGran)
                    {
                        mesGran = contador;
                        filaForques = fila;
                        colForques = col;
                    }
                }
            }
        }

        return [filaForques, colForques];
    }

    private static int BuscaZonesPerillosesForca(
        List<List<int>> zonesPerilloses, int fila, int col)
    {
        int contador = 0;

        for (int i = fila - 1; i <= fila + 1; i++)
        {
            for (int j = col - 1; j <= col + 1; j++)
            {
                if (i >= 0 && i < zonesPerilloses.Count &&
                    j >= 0 && j < zonesPerilloses[i].Count)
                {
                    if ((i != fila || j != col) &&
                        zonesPerilloses[i][j] == 1)
                    {
                        contador++;
                    }
                }
            }
        }

        return contador;
    }
}
