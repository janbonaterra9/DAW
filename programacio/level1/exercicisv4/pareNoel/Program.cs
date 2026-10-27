namespace pareNoel;

class Program
{
    static void Main(string[] args)
    {
        string lines = System.IO.File.ReadAllText(@"/home/oliverr/Desktop/DAW/programacio/level1/exercicisv4/pareNoel/DAW-M3-UF5-01.txt");
        Console.WriteLine($"Haurà de visitar un total de {lines.Length} cases");

        List<String> cords = [];
        int x = 0;
        int y = 0;

        cords.Add($"{x},{y}");

        RecorrerTotesLesCases(cords, x, y, lines);
        Console.WriteLine($"El substitut portarà regals a {cords.Count} cases");

        while(true)
        {
            Console.Write("Vols veure totes les cases a les que ha anat? Y o N ");
            var resultatCases = Console.ReadLine();
            if (resultatCases != "Y" && resultatCases != "y" && resultatCases != "N" && resultatCases != "n")
            {
                Console.WriteLine("Has entrat malament la resposta.");
                continue;
            }

            if (resultatCases == "Y" || resultatCases == "y")
            {
                for(int i=0; cords.Count > i; i++)
                {
                    Console.Write($"{cords[i]} | ");
                }
                return;
            }
            else
            {
                return;
            }
        }
    }

  static void RecorrerTotesLesCases(List<string> cords, int x, int y, string lines)
  {
    string posicioActual = $"{x}, {y}";
    for(int i=0; lines.Length > i; i++)
        {
            if (lines[i] == '<')
            {
                x -= 1;
            } else if (lines[i] == '>')
            {
                x += 1;
            } else if (lines[i] == '^')
            {
                y -= 1;
            } else if (lines[i] == 'v')
            {
                y += 1;
            }
            posicioActual = $"{x}, {y}";

            if (!cords.Contains(posicioActual))
            {
                cords.Add(posicioActual);
            } else
            {
                cords.Remove(posicioActual);
            }
        }
  }
}
