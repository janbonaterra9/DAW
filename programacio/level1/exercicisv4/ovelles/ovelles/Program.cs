namespace ovelles;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Les ovelles d’Escòcia");
        Console.WriteLine();

        try
        {

            Console.Write("Entra els colors separats per espais: ");
            var llistaColors = Console.ReadLine();
            var colors = llistaColors!.Split(" ");

            var negres = 0;
            var blanques = 0;
            var blancINegre = 0;

            if (colors.Length % 2 == 1)
            {
                throw new Exception("Aquesta llista no està bé");
            }

            for (int i = 0; i < colors.Length; i++)
            {
                colors[i] = colors[i].Trim();
                Console.WriteLine(colors[i]);
            }

            for (int i = 0; i < colors.Length / 2; i++)
            {
                if (colors[i] == "blanca" && colors[(colors.Length - 1) - i] == "blanca")
                {
                    blanques++;
                }
                else if (colors[i] == "negra" && colors[(colors.Length - 1) - i] == "negra")
                {
                    negres++;
                }
                else
                {
                    blancINegre++;
                }
            }


            Console.WriteLine(
                $"Resultat: A Escòcia hi ha {blanques} ovella blanca, {negres} de negra i {blancINegre} de blanc-i-negres");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}