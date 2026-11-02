namespace rapunzel;

class Program
{
    static void Main(string[] args)
    {
        List<string> princeps = ["Príncep Bernat", "Príncep Arnau", "Príncep Guillem", "Príncep Guerau", "Princep Hug"];

        while(princeps.Count > 1)
        {
            int tantPerCent = (int)(princeps.Count * 0.20);
            if(tantPerCent >= 1)
            {
                for(int i=0; i<tantPerCent; i++)
                {   if(i==0)
                    {
                        Console.WriteLine($"-- Rapunzel talla {tantPerCent} candidat dels de darrera. Cau el {princeps[princeps.Count - 1]}");
                    } else
                    {
                        Console.WriteLine($"Cau el {princeps[princeps.Count - 1]}");
                    }
                    princeps.RemoveAt(princeps.Count - 1);
                }
            }
            else
            {
                int sacsejarCabell = princeps.Count / 2;
                if(princeps.Count % 2 == 0)
                {
                    Console.WriteLine($"-- Rapunzel sacseja el cabell, com que són parells n'hi ha dos al mig. Cau el primer del mig, el {princeps[sacsejarCabell - 1]}");
                    princeps.RemoveAt(sacsejarCabell - 1);
                }
                else
                {
                    Console.WriteLine($"-- Rapunzel sacseja el cabell. Cau el del mig, el {princeps[sacsejarCabell]}");
                    princeps.RemoveAt(sacsejarCabell);
                }
            }
        }

        Console.WriteLine($"Ha guanyat el {princeps[0]}");
    }
}
