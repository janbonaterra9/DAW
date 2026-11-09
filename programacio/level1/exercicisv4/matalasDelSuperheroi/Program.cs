using System.Runtime.CompilerServices;

namespace matalasDelSuperheroi;

class Program
{
    static void Main(string[] args)
    {
        List<List<char>> mapa = [
          [' ', ' ', 's', ' ', ' '],
          [' ', ' ', ' ', ' ', ' '],
          [' ', ' ', '#', ' ', '#'],
          ['#', '#', '#', ' ', ' '],
          [' ', 'x', ' ', ' ', ' ']
        ];

        List<int> sortidaSuperheroi = [];

        for(int i=0;i<mapa.Count;i++)
        {
            for(int j = 0; j < mapa[i].Count; j++)
            {
                if(mapa[i][j] == 's')
                {
                    sortidaSuperheroi.Add(i);
                    sortidaSuperheroi.Add(j);
                    break;
                }
            }
        }
        if(!sortidaSuperheroi.Any())
        {
            Console.WriteLine("No veig el superheroi en el mapa!!!");
            return;
        }

        bool trobat = false;
        int fila = sortidaSuperheroi[0];

        while(!trobat && fila < mapa.Count -1 )
        {
            for(int i=0; i<mapa[fila].Count;i++)
            {
                if(mapa[fila][i] == '1' || mapa[fila][i] == 's')
                {
                    if(mapa[fila+1][i] != '#')
                    {
                        if(mapa[fila+1][i] == 'x')
                        {
                            trobat = true;
                            break;
                        }
                        mapa[fila+1][i] = '1';
                    }
                    if(i > 0)
                    {
                        if(mapa[fila+1][i-1] != '#')
                        {
                            if(mapa[fila+1][i-1] == 'x')
                            {
                                trobat = true;
                                break;
                            }
                            mapa[fila+1][i-1] = '1';
                        }
                    }
                    if(i < mapa[fila].Count-1)
                    {
                        if(mapa[fila+1][i+1] != '#') {
                            if(mapa[fila+1][i+1] == 'x')
                            {
                                trobat = true;
                                break;
                            }
                            mapa[fila+1][i+1] = '1';
                        }
                    }
                    
                }
            }
            fila++;
        }

        if(trobat)
        {
            Console.WriteLine("El superheroi ha caigut al matalàs");
        } else
        {
            Console.WriteLine("El superheroi ha caigut a terra");
        }
        
    }
}
