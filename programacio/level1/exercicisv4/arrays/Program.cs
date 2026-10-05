namespace arrays;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entra es números separats per comes: ");
        var numerosstring = Console.ReadLine();

        var arrayNumeros = numerosstring!.Split(",");

        var mesgran = Convert.ToInt32(arrayNumeros[0]);
        // var mesgran = Int32.MinValue;

        foreach(var numero in arrayNumeros)
        {
            var nouNumero = Convert.ToInt32(numero);

            if (nouNumero > mesgran)
            {
                mesgran = nouNumero;
            }
        }
        Console.WriteLine($"El més gran és {mesgran}");
    }
}
