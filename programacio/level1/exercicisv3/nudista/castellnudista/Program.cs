namespace castellnudista;

public class Program
{


    public static string ComprovaEdat(int edat, int edatminima)
    {
        if (edat < edatminima)
        {
            return "Ho sento cavaller, no pots entrar al castell.";
        }
        return "Endavant cavaller! Ja pots entrar al castell.";
    }
    
    public static void Main(string[] args)
    {
        
        var edatminima = 18;
        int edat = 0;
        int vegades = 0;
        var resultat = "";
        do
        {
            try
            {
                vegades++;
                // Demanar dades
                Console.Write("Edat: ");
                var edatstring = Console.ReadLine();
                edat = Convert.ToInt32(edatstring);

                if (edat < 0 || edat > 150)
                {
                    throw new Exception("Aquesta edat és impossible");
                }
                // Comprovar la contrasenya
                resultat = ComprovaEdat(edat, edatminima);

                // Imprimir el resultat
                Console.WriteLine(resultat);
            }
            catch (FormatException)
            {
                Console.WriteLine("La edat ha de ser un número");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } while (resultat != "Endavant cavaller! Ja pots entrar al castell." && vegades < 2);
    }
}