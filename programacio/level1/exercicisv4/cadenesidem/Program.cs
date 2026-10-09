using System.Security.Principal;
using Microsoft.VisualBasic;

namespace cadenesidem;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cadenes “Ídem”");
        Console.WriteLine();

        var llistaNoms = "Poll, Llop";
        var arrayNoms = llistaNoms.Split(",");
        var paraula1 = arrayNoms[0].Trim().ToLower();
        var paraula2 = arrayNoms[1].Trim().ToLower();

        var resposta = Idem(paraula1,paraula2);
        Console.WriteLine(resposta);
    }

    public static string Idem(string paraula1, string paraula2)
    {
        int paraulesCorrectes = 0;

        if (paraula1.Length != paraula2.Length)
        {
            return "Les dos paraules no medeixen el mateix, per tant no tenen les mateixes lletres";
        }
        for(int i=0; paraula1.Length > i; i++)
        {
            while()
        }
    }
}
