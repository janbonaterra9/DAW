namespace startrekDesapareguts;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Spanish Star Trek: la tripulació desapareguda");
        Console.WriteLine();

        Console.Write("Entra tots els noms dels tripulants de la nau abans de sortir separats per comes: ");
        var fllistaTripulants = Console.ReadLine();
        if(fllistaTripulants == null)
        {
            Console.WriteLine("ERROR. No has entrat cap nom");
            return;
        }

        Console.Write("Entra tots els noms dels tripulants de la nau despres de tornar separat per comes: ");
        var fllistaTripulantsTornats = Console.ReadLine();
        if(fllistaTripulantsTornats == null)
        {
            Console.WriteLine("ERROR. No has entrat cap nom");
            return;
        }

        var llistaTripulants = fllistaTripulants.Split(",");
        var llistaTripulantsTornats = fllistaTripulantsTornats.Split(",");

        var despareguts = "";

        for (int i=0; llistaTripulants.Length > i; i++)
        {
            for (int j=0; llistaTripulantsTornats.Length > j; j++)
            {
                if(llistaTripulants[i] == llistaTripulantsTornats[j])
                {
                    break;
                } else if (j == llistaTripulantsTornats.Length - 1)
                {
                    despareguts = $"{despareguts}{llistaTripulants[i]}, ";
                }
            }
        }
        Console.WriteLine($"Han desaparegut: {despareguts[0..(despareguts.Length - 2)]}");
    }
}