namespace dustwaterCorral;

class Program
{
    static void Main(string[] args)
    {
        List<List<char>> mapa = [
            ['.', '.', 'v', 'v', '.'],
            ['.', '>', '.', '.', '.'],
            ['.', '.', '.', '.', '<'],
            ['.', '.', '.', '.', '.'],
            ['^', '.', '.', '<', '^'] 
        ];

        List<string> resposta = [];

        for(int i=0; i<mapa.Count; i++)
        {
            for(int j=0; j<mapa[i].Count;j++)
            {
                if(mapa[i][j] == '^' || mapa[i][j] == 'v' || mapa[i][j] == '>' || mapa[i][j] == '<')
                {
                    PintarLaDireccioDeLesBales(mapa, i, j);
                }
            }
        }

        ComprovarLlocsSegurs(mapa,resposta);

        if(!resposta.Any())
        {
            Console.WriteLine("No hi ha cap posició segura en el mapa");
        }
        else
        {
            
            Console.WriteLine($"Les coordenades posicions del mapa segures son les seguents:");
            for(int i=0; i<resposta.Count;i++)
            {
                Console.WriteLine(resposta[i]);
            }
        }


    }

  static void ComprovarLlocsSegurs(List<List<char>> mapa, List<string> resposta)
  {
    for(int i=0; i<mapa.Count;i++)
        {
            for(int j=0; j<mapa[i].Count;j++)
            {
                if(mapa[i][j] == '.')
                {
                    resposta.Add($"{i},{j}");
                }
            }
        }
  }

  static void PintarLaDireccioDeLesBales(List<List<char>> mapa, int i, int j)
  {
    if(mapa[i][j] == '^')
        {
            for(int k=i-1; k>=0; k--)
            {
                if(mapa[k][j] != '^' && mapa[k][j] != 'v' && mapa[k][j] != '>' && mapa[k][j] != '<')
                {
                    mapa[k][j] = 'x';
                }
            }
        } else if(mapa[i][j] == 'v')
        {
            for(int k=i+1; k<mapa.Count; k++)
            {
                if(mapa[k][j] != '^' && mapa[k][j] != 'v' && mapa[k][j] != '>' && mapa[k][j] != '<')
                {
                    mapa[k][j] = 'x';
                }
            }
        } else if(mapa[i][j] == '<')
        {
            for(int k=j-1; k>=0; k--)
            {
                if(mapa[i][k] != '^' && mapa[i][k] != 'v' && mapa[i][k] != '>' && mapa[i][k] != '<')
                {
                    mapa[i][k] = 'x';
                }
            }
        } else if(mapa[i][j] == '>')
        {
            for(int k=j+1; k<mapa[i].Count; k++)
            {
                if(mapa[i][k] != '^' && mapa[i][k] != 'v' && mapa[i][k] != '>' && mapa[i][k] != '<')
                {
                    mapa[i][k] = 'x';
                }
            }
        }
  }
}
