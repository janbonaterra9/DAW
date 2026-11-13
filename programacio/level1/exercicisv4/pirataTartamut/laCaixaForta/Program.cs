namespace laCaixaForta;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = [];

        for (int i = 0; i < 100; i++)
        {
            numeros.Add(i);
        }

        List<string> moviments = ["L68", "L30", "R48", "L5", "R60", "L55", "L1", "L99", "R14", "L82"];

        int posicio = 50;
        int copsPassatsPerZero = 0;

        for(int i=0; i<moviments.Count; i++)
        {
            bool haPassat = false;
            int numeroACalcular = 0;
            if(moviments[i][0] == 'L')
            {
                numeroACalcular = Convert.ToInt32($"-{moviments[i][1..]}");
            } 
            
            if(moviments[i][0] == 'R')
            {
                numeroACalcular = Convert.ToInt32(moviments[i][1..]);
            }

            
            if((posicio + numeroACalcular <= 0 || posicio + numeroACalcular > 99) && posicio != 0)
            {
                copsPassatsPerZero++;
                haPassat = true;
            }

            posicio = (posicio + numeroACalcular + numeros.Count) % numeros.Count;

            Console.Write($"{moviments[i]}: arriba a {posicio}. ");
            if(haPassat)
            {
                Console.WriteLine("Ha passat pel zero 1 vegada.");
            } else
            {
                Console.WriteLine("No ha passat pel zero.");
            }


        }

        Console.WriteLine($"El resultat és que ha passat pel zero un total de {copsPassatsPerZero} cops.");

    }
}
