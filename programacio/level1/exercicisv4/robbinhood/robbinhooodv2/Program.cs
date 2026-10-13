namespace robbinhooodv2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("La punteria de Robin Hood V2");
        Console.WriteLine();

        Console.Write("Entra els sorolls de la diana: ");
        var fsorollsString = Console.ReadLine();
        if (fsorollsString == null)
        {
            Console.WriteLine("ERROR. No has entrat res!!");
            return;
        }
        var sorollsString = fsorollsString.ToUpper();

        int rec = 0;
        int ric = 0;
        int movimentReal = 0;
        var costat = "";

        for(int i=0; sorollsString.Length > i; i++)
        {
            if (sorollsString[i] == 'R' && sorollsString[i + 1] == 'E' && sorollsString[i + 2] == 'C')
            {
                rec++;
            } else if (sorollsString[i] == 'R' && sorollsString[i + 1] == 'I' && sorollsString[i + 2] == 'C')
            {
                ric++;
            }
        }

        if (rec > ric)
        {
            movimentReal = rec - ric;
            costat = "esquerra";
        } else if (rec < ric)
        {
            movimentReal = ric - rec;
            costat = "dreta";
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
