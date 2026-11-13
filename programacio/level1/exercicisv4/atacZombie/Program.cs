// using System.Collections;

// namespace atacZombie;

// class Program
// {
//     - - - - - -
//     static void Main(string[] args)
//     {
//         // crear llista de zomibes
//         List<string> zombies = ["vampir","zombie","zombie","vampir","llop"];

//         // crear llista de bales
//         List<string> bales = ["plata","all","normal","normal","plata","plata","all"];

//         // crear cartuix
//         string[] cartuix = new string[6];

//         // recarregar cartuix

//         for(int i=0; i<6; i++)
//         {
//             cartuix[i] = bales[0];
//             bales.RemoveAt(0);
//         }

//         int posicioCartuix = 0;
//         while(zombies.Count > 0)
//         {
//             // veure quin zombie ve i seleccionar la bala
//             int numeroDeMoviments = VeureQuantsMovimentsEsTenenQueFer(zombies[0], cartuix, posicioCartuix);

//             posicioCartuix = posicioCartuix + (numeroDeMoviments % posicioCartuix);

//             if(numeroDeMoviments != -1)
//             {
//                 Console.WriteLine($"Ve un {zombies[0]} i tens que rodar el cartuix {numeroDeMoviments} cops.");
//                 Console.WriteLine($"-- Posició del cartuix {posicioCartuix}");
//                 cartuix[numeroDeMoviments] = " ";
//             } else
//             {
//                 for(int i=0; i<cartuix.Length;i++)
//                 {
//                     if(cartuix[i] == " ")
//                     {

//                     }
//                 }
//             }
//         }


//     }
//      static int VeureQuantsMovimentsEsTenenQueFer(string zombie, string[] cartuix, int posicioCartuix)
//     {
//         // contar els moviments

//         switch(zombie)
//         {
//             case "vampir":
//                 for(int i=0; i<cartuix.Length;i++)
//                 {
//                     if(cartuix[i % cartuix.Length] == "all")
//                     {
//                         return i;
//                     }
//                 }
//                 break;
//             case "zombie":
//                 for(int i=0; i<cartuix.Length; i++)
//                 {
//                     if(cartuix[i % cartuix.Length] == "normal")
//                     {
//                         return i;
//                     }
//                 }
//                 break;
//             case "llop":
//                 for(int i=0; i<cartuix.Length; i++)
//                 {
//                     if(cartuix[i % cartuix.Length] == "plata")
//                     {
//                         return i;
//                     }
//                 }
//                 break;
//         }
//         return -1;
//     }
// }


using System.Collections;

namespace atacZombie;

class Program
{
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

         // mostrar les bales recarregades
         Console.Write("S'han recarregat les seguents bales: ");
         for(int i=0; i<6; i++)
        {
            Console.Write($"{cartuix[i]} ");
        }
        Console.WriteLine();
        Console.WriteLine();
        int posicioCartuix = 0;
        while(zombies.Count>0)
        {
            // veure quin es el zombie i retornar el numero de moviments del cartuix

            int numeroDeMoviments = VeureQuantsMovimentsEsTenenQueFer(zombies[0], cartuix, posicioCartuix);

            // Si s' ha trobat la bala al cartuix...
            if(numeroDeMoviments != -1)
            {
                posicioCartuix = (posicioCartuix+numeroDeMoviments) % cartuix.Length;
                Console.WriteLine($"Ve un {zombies[0]} i tens que rodar el cartuix {numeroDeMoviments} cops. Dispares i rodes 1 cop més.");
                cartuix[posicioCartuix] = " ";
                posicioCartuix = (posicioCartuix+1) % cartuix.Length;
                Console.WriteLine($"-- Posició del cartuix {posicioCartuix + 1}");
                Console.WriteLine();
                zombies.RemoveAt(0);
            } 
            // si no s'ha trobat la bala ... 
            else
            {
                List<int> espaiLliureCartuixIEspaiBalaNecessaria = [-1 ,-1];
                HiHaUnEspaiLliure(cartuix, bales, zombies[0], espaiLliureCartuixIEspaiBalaNecessaria);


                // si hi ha un espai lliure i existeix la bala fora de del cartuix del tipus
                


                if(espaiLliureCartuixIEspaiBalaNecessaria[0] != -1 && espaiLliureCartuixIEspaiBalaNecessaria[1] != -1)
                {
                    int movimentsNecessaris = 0;
                    while(cartuix[posicioCartuix] != " ")
                    {
                        movimentsNecessaris++;
                        posicioCartuix = (posicioCartuix+1) % cartuix.Length;
                    }


                    Console.WriteLine($"No hi ha cap bala al cartuix per matar al {zombies[0]}, tindràs que moure't {movimentsNecessaris} posicions per poder recarregar la bala");
                    cartuix[posicioCartuix] = bales[espaiLliureCartuixIEspaiBalaNecessaria[1]];
                    bales.RemoveAt(espaiLliureCartuixIEspaiBalaNecessaria[1]);
                    Console.WriteLine($"Bala recarregada a posicio {posicioCartuix +1} i roda.");
                    Console.WriteLine($"-- Saltes 5 posicions i tornes a la bala {posicioCartuix +1}.");
                    Console.WriteLine();
                    Console.WriteLine($"Mates al {zombies[0]} i tens que rodar el cartuix una posició");
                    cartuix[posicioCartuix] = " ";
                    posicioCartuix = (posicioCartuix+1) % cartuix.Length;
                    Console.WriteLine($"-- Posicio del cartuix {posicioCartuix +1}");
                    Console.WriteLine();
                    zombies.RemoveAt(0);
                    
                } else
                {
                    Console.WriteLine($"No hi ha cap bala al cartuix per matar al {zombies[0]} i tampoc es pot recarregar, ja que no hi ha cap lloc lliure o no queden bales del tipus. Estas mort burro!!");
                    return;
                }
            }
        }
        Console.WriteLine("Has matat a tota la horda!");
    }
    static int VeureQuantsMovimentsEsTenenQueFer(string zombie, string[] cartuix, int posicioCartuix )
    {
        switch(zombie)
        {
            case "vampir":
                for(int i=0; i < cartuix.Length;i++)
                {
                    if(cartuix[posicioCartuix] == "all")
                    {
                        return i;
                    }
                    posicioCartuix = (posicioCartuix+1) % cartuix.Length;
                }
            break;
            case "zombie":
                for(int i=0; i < cartuix.Length;i++)
                {
                    if(cartuix[posicioCartuix] == "normal")
                    {
                        return i;
                    }
                    posicioCartuix = (posicioCartuix+1) % cartuix.Length;
                }
            break;
            case "llop":
                for(int i=0; i < cartuix.Length;i++)
                {
                    if(cartuix[posicioCartuix] == "plata")
                    {
                        return i;
                    }
                    posicioCartuix = (posicioCartuix+1) % cartuix.Length;
                }
            break;
        }
        return -1;
    }

    static void HiHaUnEspaiLliure(string[] cartuix, List<string> bales, string zombie, List<int> espaiLliureiBala)
    {
        for(int i=0; i<cartuix.Length; i++)
        {
            if(cartuix[i] == " ")
            {
                for(int j=0; j<bales.Count; j++)
                {
                    switch(zombie)
                    {
                        case "vampir":
                            if(bales[j] == "all")
                            {
                                espaiLliureiBala[0] = i;
                                espaiLliureiBala[1] = j;
                                return;
                            }
                        break;
                        case "zombie":
                            if(bales[j] ==  "normal")
                            {
                                espaiLliureiBala[0] = i;
                                espaiLliureiBala[1] = j;
                                return;
                            }
                        break;
                        case "llop":
                            if(bales[j] == "plata")
                            {
                                espaiLliureiBala[0] = i;
                                espaiLliureiBala[1] = j;
                                return;
                            }
                        break;
                    }
                }
            }
        }
        espaiLliureiBala[0] = -1;
        espaiLliureiBala[1] = -1;
    }
}
