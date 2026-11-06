using System.Globalization;

namespace sopaGastronomica;

class Program
{
    static void Main(string[] args)
    {
        // List<List<char>> sopa = [
        //     ['T', 'B', 'N', 'E', 'T', 'A', 'R'],
        //     ['M', 'O', 'A', 'P', 'O', 'Z', 'C'],
        //     ['T', 'X', 'M', 'T', 'M', 'T', 'L'],
        //     ['U', 'O', 'N', 'A', 'A', 'E', 'T'],
        //     ['I', 'O', 'T', 'B', 'T', 'N', 'T'],
        //     ['S', 'O', 'O', 'O', 'A', 'A', 'N'],
        //     ['T', 'O', 'M', 'E', 'T', 'A', 'S']
        // ];

        List<List<char>> sopa = [
            ['P', 'I', 'S', 'T', 'O', 'D', 'R'],
            ['X', 'O', 'A', 'P', 'O', 'Z', 'C'],
            ['S', 'X', 'P', 'A', 'S', 'P', 'A'],
            ['T', 'O', 'A', 'A', 'A', 'I', 'T'],
            ['A', 'O', 'S', 'B', 'S', 'S', 'T'],
            ['S', 'O', 'T', 'O', 'A', 'T', 'N'],
            ['T', 'P', 'A', 'N', 'T', 'A', 'G']
        ];

        List<string> paraulesTrobades = [];
        
        string paraulaBuscada = "PASTA";


        for(int fila=0; fila<sopa.Count;fila++)
        {
            for(int col=0; col<sopa[fila].Count;col++)
            {
                if(sopa[fila][col] == paraulaBuscada[0])
                {
                    BuscarLaParaula(sopa, fila, col, paraulesTrobades, paraulaBuscada);
                }
            }
        }


        
        Console.WriteLine(String.Join(",",paraulesTrobades));
        




    }
    static void BuscarLaParaula(List<List<char>> sopa, int fila, int col, List<string> paraulesTrobades, string paraulaBuscada)
    {
        // Buscar en Vertical

        if(BuscarLaParaulaVertical(sopa, fila, col, paraulesTrobades, paraulaBuscada))
        {
            var paraulaTrobada = "";
            int j=fila;
            for(int i=0; i<paraulaBuscada.Length; i++)
            {

                paraulaTrobada += sopa[j][col];
                j++;
            }

            paraulesTrobades.Add(paraulaTrobada);
        }

        // Buscar en Horitzontal

        if(BuscarLaParaulaHoritzontal(sopa, fila, col, paraulesTrobades, paraulaBuscada))
        {
            var paraulaTrobada = "";
            int j=col;
            for(int i=0; i<paraulaBuscada.Length; i++)
            {

                paraulaTrobada += sopa[fila][j];
                j++;
            }
            paraulesTrobades.Add(paraulaTrobada);
        }

        // Buscar en Diagonal

        if(BuscarLaParaulaDiagonal(sopa, fila, col, paraulesTrobades, paraulaBuscada))
        {
            var paraulaTrobada = "";
            int j=fila;
            int k= col;
            for(int i=0; i<paraulaBuscada.Length; i++)
            {

                paraulaTrobada += sopa[j][k];
                j++;
                k++;
            }
            paraulesTrobades.Add(paraulaTrobada);
        }
    }

    static bool BuscarLaParaulaVertical(List<List<char>> sopa, int fila, int col, List<string> paraulesTrobades, string paraulaBuscada)
    {
        var copsEquivocats = 0;
        bool trobada = false;
        var posicioParaulaBuscada = 0;

        while(!trobada && copsEquivocats<=1 && fila<sopa.Count)
        {
            if(sopa[fila][col] != paraulaBuscada[posicioParaulaBuscada])
            {
                copsEquivocats++;
            }

            fila++;
            if(posicioParaulaBuscada == paraulaBuscada.Length -1 && copsEquivocats <=1)
            {
                return true;
            }
            posicioParaulaBuscada++;
        }

        return false;
    }
    static bool BuscarLaParaulaHoritzontal(List<List<char>> sopa, int fila, int col, List<string> paraulesTrobades, string paraulaBuscada)
    {
        var copsEquivocats = 0;
        bool trobada = false;
        var posicioParaulaBuscada = 0;

        while(!trobada && copsEquivocats<=1 && col<sopa[fila].Count)
        {
            if(sopa[fila][col] != paraulaBuscada[posicioParaulaBuscada])
            {
                copsEquivocats++;
            }

            col++;
            if(posicioParaulaBuscada == paraulaBuscada.Length -1 && copsEquivocats <=1)
            {
                return true;
            }
            posicioParaulaBuscada++;
        
        }

        return false;
        
    }
    static bool BuscarLaParaulaDiagonal(List<List<char>> sopa, int fila, int col, List<string> paraulesTrobades, string paraulaBuscada)
    {
        var copsEquivocats = 0;
        bool trobada = false;
        var posicioParaulaBuscada = 0;

        while(!trobada && copsEquivocats<=1 && fila<sopa.Count && col<sopa[fila].Count )
        {
            if(sopa[fila][col] != paraulaBuscada[posicioParaulaBuscada])
            {
                copsEquivocats++;
            }

            col++;
            fila++;
            if(posicioParaulaBuscada == paraulaBuscada.Length -1 && copsEquivocats <=1)
            {
                return true;
            }
            posicioParaulaBuscada++;
        }

        return false;
    }
}
