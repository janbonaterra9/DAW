namespace pareNoelEstiu;

class Program
{
    static void Main(string[] args)
    {
        // crear llista de potències
        List<List<int>> potencies = [
            [5, 4, 8, 3, 1, 4, 3, 2, 2, 3],
            [2, 7, 4, 5, 8, 5, 4, 7, 1, 1],
            [5, 2, 6, 4, 5, 5, 6, 1, 7, 3],
            [6, 1, 4, 1, 3, 3, 6, 1, 4, 6],
            [6, 3, 5, 7, 3, 8, 5, 4, 7, 8],
            [4, 1, 6, 7, 5, 2, 4, 6, 4, 5],
            [2, 1, 7, 6, 8, 4, 1, 7, 2, 1],
            [6, 8, 8, 2, 8, 8, 1, 1, 3, 4],
            [4, 8, 4, 6, 8, 4, 8, 5, 5, 4],
            [5, 2, 8, 3, 7, 5, 1, 5, 2, 6]
        ];

        // crear bucle fins que totes les bombetes tinguin potència 9
        bool totesEnceses = false;
        int segonsTotals = 0;
        while(!totesEnceses)
        {
            PassarUnsegon(potencies);
            segonsTotals++;

            // Comprovar si estan totes les bombetes enceses
            if(EstanTotesEnceses(potencies))
            {
                totesEnceses = true;
            }
        }
        Console.WriteLine($"S'han necessitat un total de {segonsTotals} segons.");
    }
    static void PassarUnsegon(List<List<int>> potencies)
    {
        // comprovar si tenen 9 al voltant
        for(int i=0; i<potencies.Count;i++)
        {
            for(int j=0;j<potencies[i].Count;j++)
            {
                if(i == 0 && j == 0)
                {
                    if(potencies[i][j+1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i+1][j+1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i+1][j] == 9){potencies[i][j] += 1 % 9;}
                } else if (i == 0 && j == potencies.Count-1)
                {
                    if(potencies[i][j-1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i+1][j-1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i+1][j] == 9){potencies[i][j] += 1 % 9;}
                } else if(i== potencies.Count-1 && j == 0)
                {
                    if(potencies[i-1][j+1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i-1][j] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i][j+1] == 9){potencies[i][j] += 1 % 9;}
                } else if(i == potencies.Count-1 && j == potencies.Count-1)
                {
                    if(potencies[i-1][j-1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i-1][j] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i][j-1] == 9){potencies[i][j] += 1 % 9;}
                } else if(i == 0)
                {
                    if(potencies[i][j-1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i+1][j-1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i+1][j] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i+1][j+1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i][j+1] == 9){potencies[i][j] += 1 % 9;}
                } else if(i == potencies.Count-1)
                {
                    if(potencies[i][j-1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i-1][j-1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i-1][j] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i-1][j+1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i][j+1] == 9){potencies[i][j] += 1 % 9;}
                } else if(j == 0)
                {
                    if(potencies[i-1][j] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i-1][j+1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i][j+1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i+1][j+1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i+1][j] == 9){potencies[i][j] += 1 % 9;}
                } else if(j == potencies.Count-1)
                {
                    if(potencies[i-1][j] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i-1][j-1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i][j-1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i+1][j-1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i+1][j] == 9){potencies[i][j] += 1 % 9;}
                } else
                {
                    if(potencies[i+1][j] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i+1][j+1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i][j+1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i-1][j+1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i-1][j] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i-1][j-1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i][j-1] == 9){potencies[i][j] += 1 % 9;}
                    if(potencies[i+1][j-1] == 9){potencies[i][j] += 1 % 9;}
                }
            }
        }
        // sumar un a cada un
        for(int i=0; i<potencies.Count; i++)
        {
            for(int j=0; j<potencies[i].Count; j++)
            {
                potencies[i][j] += 1 % 9;
            }
        }

    }
    static bool EstanTotesEnceses(List<List<int>> potencies)
    {
        for(int i=0; i<potencies.Count; i++)
        {
            for(int j=0; j<potencies[i].Count;j++)
            {
                if(potencies[i][j] != 9)
                {
                    return false;
                }
            }
        }
        return true;
    }
}
