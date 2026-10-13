namespace ex1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercici 1. Quin és el segon número més gran?");
        Console.WriteLine();
        
        Console.Write("Entra una llista de numeros enters separats per comes: ");
        var llistaNum =  Console.ReadLine();
        if (llistaNum == null)
        {
            Console.WriteLine("Tens que entrar algo.");
            return;
        }
        var arrayNum = llistaNum.Split(",");
        int[] numeros = new int[arrayNum.Length];
        for(int i=0; arrayNum.Length > i; i++)
        {
            numeros[i] = Convert.ToInt32(arrayNum[i].Trim());
        }

        
        int mesGran;
        int segonMesGran;

        if (numeros[0] > numeros[1])
        {
            mesGran = numeros[0];
            segonMesGran = numeros[1];
        } else
        {
            mesGran = numeros[1];
            segonMesGran = numeros[0];
        }

        for (int i = 2; numeros.Length > i; i++)
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