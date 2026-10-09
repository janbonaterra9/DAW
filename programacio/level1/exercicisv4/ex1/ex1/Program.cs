namespace ex1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercici 1. Quin és el segon número més gran?");
        Console.WriteLine();
        
        int[] numeros = [5,4,3,2,1];
        
        int mesGran = numeros[0];
        int segonMesGran = numeros[0];

        for (int i = 1; numeros.Length > i; i++)
        {
            if (numeros[i] > mesGran)
            {
                segonMesGran = mesGran;
                mesGran = numeros[i];
            } else if (numeros[i] > segonMesGran)
            {
                segonMesGran = numeros[i];
            }
        }
        Console.WriteLine($"El segon més gran és {segonMesGran}");
    }
}