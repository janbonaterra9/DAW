namespace amagaElNumero;

class Program
{
    static void Main(string[] args)
    {
        var numeros = "811111111111190";

        int numeroDobleMesGrans = VeureElNumeroMesGranSeguintElOrdre(numeros);

        Console.WriteLine(numeroDobleMesGrans);
    }
    
    static int VeureElNumeroMesGranSeguintElOrdre(string numeros)
    {
        char primerNumero = numeros[0];
        int posicioPrimerNumero = 0;

        for(int i=1; i<numeros.Length - 1;i++)
        {
            if(Convert.ToInt32(primerNumero) < Convert.ToInt32(numeros[i]))
            {
                primerNumero = numeros[i];
                posicioPrimerNumero = i;
            }
        }
    
        char segonNumero = numeros[posicioPrimerNumero + 1];

        for(int i=posicioPrimerNumero + 1;i<numeros.Length;i++)
        {
            if(Convert.ToInt32(segonNumero) < Convert.ToInt32(numeros[i]))
            {
                segonNumero = numeros[i];
            }
        }
        var numeroFinal = Convert.ToInt32($"{primerNumero}{segonNumero}");
        return numeroFinal;
    }
}
