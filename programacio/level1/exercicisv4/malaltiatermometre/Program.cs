namespace malaltiatermometre;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("La malaltia del termòmetre");
        Console.WriteLine();

        try
        {
            Console.Write("Entra totes les temperatures de l'any separedes per un espai: ");
            var temperatures = Console.ReadLine();

            if (temperatures == null)
            {
                Console.WriteLine("ERROR, no has entrat les temperatures!");
                return;
            }
            
            if (temperatures[0] == ' ' || temperatures[temperatures.Length - 1] == ' ')
            {
                Console.WriteLine("ERROR, has introduit algun espai al principi o al final!");
                return;
            }
            var temperaturesArrayString = temperatures.Split(' ');
            double[] temperaturesArrayInt = new double[temperaturesArrayString.Length];

            for (int i=0; i<temperaturesArrayString.Length; i++)
            {
                temperaturesArrayInt[i] = Convert.ToDouble(temperaturesArrayString[i]);
            }

            string resposta = ComprovarLaTemperaturaMesAlta(temperaturesArrayInt);
            Console.WriteLine(resposta);
        } catch(FormatException)
        {
            Console.WriteLine("ERROR, has introduit alguna lletra, només pots introduir temperatures.");
        }
    }

  private static string ComprovarLaTemperaturaMesAlta(double[] temperaturesArray)
  {
    var mesAlta = temperaturesArray[0];
    for(int i=1; temperaturesArray.Length > i; i++)
        {
            if (temperaturesArray[i] > mesAlta)
            {
                mesAlta = temperaturesArray[i];
            } 
        }

    var vegades = ComprovarVegadesAssolides(mesAlta, temperaturesArray);
    if (vegades == 1)
        {
          return $"Temperatura més alta: {mesAlta}ºC.\nS'ha assolit {vegades} vegada.";  
        }
    return $"Temperatura més alta: {mesAlta}ºC.\nS'ha assolit {vegades} vegades.";
  }

  private static int ComprovarVegadesAssolides(double mesAlta, double[] temperaturesArray)
  {
    var vegades = 0;
    foreach (var temperatura in temperaturesArray)
        {
            if (mesAlta == temperatura)
            {
                vegades++;
            }
        }

    return vegades;
  }
}
