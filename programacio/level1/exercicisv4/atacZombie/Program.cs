using System.Collections;

namespace atacZombie;

class Program
{
    - - - - - -
    static void Main(string[] args)
    {
        // crear llista de zomibes
        List<string> zombies = ["vampir","zombie","zombie","vampir","llop"];

        // crear llista de bales
        List<string> bales = ["plata","all","normal","normal","plata","plata","all"];

        // crear cartuix
        string[] cartuix = new string[6];

        // recarregar cartuix

        for(int i=0; i<6; i++)
        {
            cartuix[i] = bales[0];
            bales.RemoveAt(0);
        }

        int posicioCartuix = 0;
        while(zombies.Count > 0)
        {
            // veure quin zombie ve i seleccionar la bala
            int numeroDeMoviments = VeureQuantsMovimentsEsTenenQueFer(zombies[0], cartuix, posicioCartuix);

            posicioCartuix = numeroDeMoviments % posicioCartuix;
                
            if(numeroDeMoviments != -1)
            {
                Console.WriteLine($"Ve un {zombies[0]} i tens que rodar el cartuix {numeroDeMoviments} cops.");
                Console.WriteLine($"-- Posició del cartuix {posicioCartuix}");
                cartuix[numeroDeMoviments] = " ";
            } else
            {
                for(int i=0; i<cartuix.Length;i++)
                {
                    if(cartuix[i] == " ")
                    {
                        
                    }
                }
            }
        }


    }
     static int VeureQuantsMovimentsEsTenenQueFer(string zombie, string[] cartuix, int posicioCartuix)
    {
        // contar els moviments

        switch(zombie)
        {
            case "vampir":
                for(int i=0; i<cartuix.Length;i++)
                {
                    if(cartuix[i] == "all")
                    {
                        return i;
                    }
                }
                break;
            case "zombie":
                for(int i=0; i<cartuix.Length; i++)
                {
                    if(cartuix[i] == "normal")
                    {
                        return i;
                    }
                }
                break;
            case "llop":
                for(int i=0; i<cartuix.Length; i++)
                {
                    if(cartuix[i] == "plata")
                    {
                        return i;
                    }
                }
                break;
        }
        return -1;
    }
}
