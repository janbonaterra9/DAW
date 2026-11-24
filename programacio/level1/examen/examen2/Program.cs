namespace examen2;

class Program
{
    static void Main(string[] args)
    {
        List<int> barrils = [2, 4, 5, 1, 3];
        int inicial = 1;
        List<int> encesos = [];
        encesos.Add(inicial);
        int tirada = 0;
        while(NoHaginExplotatTots(barrils, encesos))
        {
            string tiradaActual = PassarBarrilsAString(barrils);
            Console.WriteLine($"Tirada {tirada}: {tiradaActual}");
            if(HaExplotatAlgunBarril(barrils, encesos))
            {
                for(int i=0; i<barrils.Count;i++)
                {
                    if(barrils[i] == 0 && encesos.Contains(i))
                    {
                        Console.WriteLine($"El barril {i} ha explotat");
                        encesos.Remove(i);

                        for(int j=i-2; j<= i+2; j++)
                        {
                            if(j>=0 && j< barrils.Count)
                            {
                                if(barrils[j] >  0 && !encesos.Contains(j))
                                {
                                    Console.WriteLine($"S'ha ences el barril {j}");
                                    encesos.Add(j);
                                }
                            }
                        }
                    }
                }
            }
            for(int i=0; i<barrils.Count;i++)
            {
                if(encesos.Contains(i))
                {
                    barrils[i]--;
                }
            }

            tirada++;
        }
        Console.WriteLine(tirada);
    }
    static bool NoHaginExplotatTots(List<int> barrils, List<int> encesos)
    {
        if(!encesos.Any())
        {
            return false;
        }
        for(int i=0; i<barrils.Count;i++)
        {
            if(barrils[i] > 0)
            {
                return true;
            }
        }
        return false;
    }
    static string PassarBarrilsAString(List<int> barrils)
    {
        string resposta = "[";
        for(int i=0; i<barrils.Count;i++)
        {
            if(i == barrils.Count-1)
            {
                resposta += $"{barrils[i]}";
            } else
            {
                resposta += $"{barrils[i]}, ";
            }
        }
        resposta += "]";
        return resposta;
    }
    static bool HaExplotatAlgunBarril(List<int> barrils, List<int> encesos)
    {
        for(int i=0; i<barrils.Count;i++)
        {
            if(barrils[i] == 0 && encesos.Contains(i))
            {
                return true;
            }
        }
        return false;
    }
}
