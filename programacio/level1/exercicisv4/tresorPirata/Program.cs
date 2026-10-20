using System.Diagnostics.Contracts;

namespace tresorPirata;

class Program
{
    static void Main(string[] args)
    {
        string[][] mapa = {
            [".",".",".",".",".",".","."],
            [".",".",".",".",".",".","."],
            [".",".",".",".",".",".","."],
            [".",".",".",".",".","#","."],
            [".",".",".",".",".",".","."]
        };

        int tresorY = -1;
        int tresorX = -1;

        for(int i=0; i < mapa.Length; i++)
        {
            if (i != 0)
            {
            Console.Write("\n");
            }
            for(int j=0; j < mapa[i].Length; j++ )
            {
                Console.Write(mapa[i][j]);
                if (mapa[i][j] == "t" || mapa[i][j] == "T")
                {
                    tresorY = j;
                    tresorX = i;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Resultat:");
        Console.WriteLine();
        if (tresorX != -1)
        {
            Console.WriteLine($"Tresor trobat a: ({tresorX},{tresorY})");
            Console.WriteLine($"Distància al límit superior: {tresorX}");
            Console.WriteLine($"Distància al límit esquerre: {tresorY}");
            return;
        } 

        Console.WriteLine("T'han enredat, no hi ha cap tresor.");
    }
}