namespace revoltaRobot;

class Program
{
    static void Main(string[] args)
    {
        List<string> robots = ["Roomba", "Thermomix", "Cafetera", "Microones"];
        List<int> numeros = [5, 2];

        int posicioNumeros = 0;
        int posicioRobot = 0;
        
        while (robots.Count > 1)
        {
            posicioRobot = posicioRobot - 1 + numeros [posicioNumeros] % robots.Count;

            Console.WriteLine($"S'ha eliminat el robot {robots[posicioRobot]}");
            robots.RemoveAt(posicioRobot);
            posicioNumeros = (posicioNumeros + 1) % numeros.Count;
        }

        Console.WriteLine($"El robot restant és {robots[0]}");
    }
}
