using System.Reflection.Metadata.Ecma335;

namespace cadenesidem;

class Program
{
    const int noTrobada = -1;
    static void Main(string[] args)
    {
        Console.WriteLine("Cadenes “Ídem”");
        Console.WriteLine();

        Console.Write("Entra les dues frases separedes per una coma: ");
        var frases = Console.ReadLine();

        if (frases == null)
        {
            Console.WriteLine("ERROR, entra agluna cosa!");
            return;
        }

        var frasesSeparades = frases.Split(",");
        if (frasesSeparades.Length != 2)
        {
            Console.WriteLine("ERROR, tens que entrar dos paraules!");
            return;
        }

        string resposta =  ComprovaSiLesParaulesSonIdem(frasesSeparades[0],frasesSeparades[1]);
        Console.WriteLine(resposta);
    }

    public static string ComprovaSiLesParaulesSonIdem(string paraula1, string paraula2)
    {
        if (LengthSenseEspais(paraula1) != LengthSenseEspais(paraula2))
        {
            return "Les dos paraules no medeixen el mateix, per tant no tenen les mateixes lletres";
        }

        var paraula2Array = paraula2.ToCharArray();

        foreach(var lletra in paraula1)
        {
            if (lletra == ' ')
            {
                continue;
            }
            
            var posicioLletra = EnQuinLlocEstaLaLletra(lletra, paraula2Array);

            if(posicioLletra == noTrobada)
            {
                return "no";
            }
            paraula2Array[posicioLletra] = ' ';
        }

        return "si";
    }

  private static int EnQuinLlocEstaLaLletra(char lletraQueEsticBuscant, char[] paraula2)
  {
    for (int i = 0; i < paraula2.Length; i++)
    {
        char lletra2 = paraula2[i];
        if (lletraQueEsticBuscant == lletra2)
        {
            return i;
        }
    }
    return noTrobada;
  }

  private static int LengthSenseEspais(string paraula)
  {
    var suma = 0;
    foreach(var lletra in paraula)
    {
        if(lletra != ' ')
        {
            suma++;
        }
    }
    return suma;    
  }
}
