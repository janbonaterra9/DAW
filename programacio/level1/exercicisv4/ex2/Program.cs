namespace ex2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercici 2. Quin número falta");
        Console.WriteLine();

        Console.Write("Entra els nombres separats per comes: ");
        var numerosLlista = Console.ReadLine();

        var numerosArray = numerosLlista!.Split(",");
        int[] numeros = new int[numerosArray.Length];

        for(int i=0; numerosArray.Length > i; i++)
        {
            numeros[i] = Convert.ToInt32(numerosArray[i].Trim());
        }

        var mesGran = numeros[0];
        var mesPetit = numeros[0];

        for(int i=1; numeros.Length > i; i++)
        {
            if (numeros[i] > mesGran)
            {
                mesGran = numeros[i];
            }

            if (numeros[i] < mesPetit)
            {
                mesPetit = numeros[i];
            }
        }

        for (int i= mesPetit; mesGran > i; i++)
        {
            for (int j=0; numeros.Length > i; i++)
            {
                if (i == numeros[j] + 1)
                {
                    
                }
            }
        }
    }
}