namespace robbinhood;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("La punteria de Robin Hood");
        Console.WriteLine();

        Console.Write("Entra els sorolls de la diana: ");
        var fsorollsString = Console.ReadLine();
        if (fsorollsString == null)
        {
            Console.WriteLine("ERROR. No has entrat res!!");
            return;
        }

        var sorollsString = fsorollsString.ToUpper();
        var sorolls = sorollsString.Split("C", StringSplitOptions.RemoveEmptyEntries);
        for(int i=0; sorolls.Length > i; i++)
        {
            if (sorolls[i] != "RI" && sorolls[i] != "RE")
            {
                Console.WriteLine("Has entrat malament els sorolls, només pot fer \"REC\" o \"RIC\"");
                return;
            }
        }
        int rec = 0;
        int ric = 0;
        int movimentReal = 0;
        var costat = "";

        for(int i=0; sorolls.Length > i; i++)
        {
            if(sorolls[i] == "RE")
            {
                rec++;
            } else
            {
                ric++;
            }
        }

        if ( rec > ric )
        {
            costat = "esquerra";
            movimentReal = rec - ric;
        } else if (ric > rec)
        {
            costat = "dreta";
            movimentReal = ric - rec;
        }

        if (rec == ric)
        {
            Console.WriteLine($"La diana s'ha mogut {rec} cops a la esquerra i {ric} cops a la dreta, o sigui que no s'ha mogut");
        } else
        {
            Console.WriteLine($"La diana s'ha mogut {rec} cops a la esquerra i {ric} cops a la dreta, o sigui {movimentReal} a la {costat}");
        }

    }
}
