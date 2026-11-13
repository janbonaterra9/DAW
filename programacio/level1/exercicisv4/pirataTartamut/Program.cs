using System.Runtime.Versioning;

namespace pirataTartamut;

class Program
{
    static void Main(string[] args)
    {
        List<string> vaixells = ["Francès", "Anglès", "Espanyol"];

        List<List<int>> numeros = [
            [6,6,6,6,6,6,3,3,3,3,4,4,4,4],
            [3,4,3,3,3,5,3,3,3],
            [1,9,9,9,9,9,9,9,9,9,3,3,3,3,4,4,4,4,1,1]
        ];

        List<string> vaixellsCorrectes = [];
        List<int> vaixellsNusosCorrectes = [];

        for(int i = 0; i< vaixells.Count; i++)
        {
            int numeroFinal = CalcularSiElBarcoTeUnNumeroValid(numeros[i]);
            
            if(numeroFinal != -1)
            {
                vaixellsCorrectes.Add(vaixells[i]);
                vaixellsNusosCorrectes.Add(numeroFinal);

            }
            
        }

        for(int i=0; i< vaixellsCorrectes.Count; i++)
        {
            Console.Write($"{vaixellsCorrectes[i]} {vaixellsNusosCorrectes[i]} nusos");
            Console.WriteLine();
        }
    }

    static int CalcularSiElBarcoTeUnNumeroValid(List<int> numeros)
    {
        List<int> numerosComprovats = [];
        
        string numeroFinal = "";
        for(int i=0; i<numeros.Count; i++)
        {
            if(!numerosComprovats.Contains(numeros[i]))
            {
                int numeroActual = numeros[i];
                numerosComprovats.Add(numeros[i]);
                
                int contadorNumeroActual = 0;
                for(int j=0; j<numeros.Count; j++)
                {
                    if(numeros[j] == numeroActual)
                    {
                        contadorNumeroActual++;
                    }

                }
                if(contadorNumeroActual == numeroActual)
                {
                    numeroFinal += $"{numeroActual}";
                }
                
            }
        }
            

            
        if(numeroFinal.Length > 0)
        {
            return Convert.ToInt32(numeroFinal);
        }

        return -1;
    }



}
