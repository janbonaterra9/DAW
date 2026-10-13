namespace startrek;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Spanish Star Trek El més ràpid de l’espai");
        Console.WriteLine();

        Console.Write("Entra totes les naus separades per comes: ");
        var fnaus = Console.ReadLine();
        if (fnaus == null)
        {
            Console.WriteLine("ERROR, no has entrat cap nau.");
            return;
        }
        Console.Write("Entra el temps que han tardat separat per espais amb el mateix ordre que has entrat les naus: ");
        var ftemps = Console.ReadLine();
        if (ftemps == null)
        {
            Console.WriteLine("ERROR, no has entrat cap temps.");
            return;
        }

        var naus = fnaus.Split(",");
        var tempsArray = ftemps.Split(" ");
        double[] temps = new double[tempsArray.Length];

        for (int i=0; tempsArray.Length > i; i++)
        {
            temps[i] = Convert.ToDouble(tempsArray[i].Trim());
        }

        var guanyadorTemps = temps[0];
        var guanyadorNau = naus[0];

        for (int i=1; temps.Length > i; i++)
        {
            if (temps[i] < guanyadorTemps)
            {
                guanyadorTemps = temps[i];
                guanyadorNau = naus[i];
            }
        }

        Console.WriteLine($"La cursa l'ha guanyat la nau {guanyadorNau} Enterprise amb {(int)guanyadorTemps} hores i {(int)((guanyadorTemps - (int)guanyadorTemps) * 100)} minuts");
    }
}