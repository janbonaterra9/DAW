class Program
{
    static void Main(string[] args)
    {
        List<List<int>> tabler = [
            [0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 1, 1, 1, 1, 1, 1, 1, 0],
            [0, 1, 2, 2, 2, 2, 2, 1, 0],
            [0, 1, 2, 5, 5, 5, 2, 1, 0],
            [0, 1, 2, 5, 10, 5, 2, 1, 0],
            [0, 1, 2, 5, 5, 5, 2, 1, 0],
            [0, 1, 2, 2, 2, 2, 2, 1, 0],
            [0, 1, 1, 1, 1, 1, 1, 1, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0]
        ];

        Random random = new Random();
        int jugador1 = 0;
        int jugador2 = 0;


        while(jugador1 < 15 && jugador2 < 15)
        {
            int randomxJugador1 = random.Next(0,9);
            int randomyJugador1 = random.Next(0,9);
            jugador1 += tabler[randomyJugador1][randomxJugador1];
            Console.WriteLine($"Jugador 1 tira a ({randomxJugador1},{randomyJugador1}) - {jugador1}");



            int randomxJugador2 = random.Next(0,9);
            int randomyJugador2 = random.Next(0,9);
            jugador2 += tabler[randomyJugador2][randomxJugador2];
            Console.WriteLine($"Jugador 2 tira a ({randomxJugador2},{randomyJugador2}) - {jugador2}");
        }
        if(jugador1 > jugador2)
        {
            Console.WriteLine($"Ha guanyat el Jugador 1 {jugador1} a {jugador2}");
            return;
        } else if(jugador2 > jugador1)
        {
            Console.WriteLine($"Ha guanyat el Jugador 2 {jugador2} a {jugador1}");
            return;
        }

        while(jugador1 == jugador2)
        {
            int randomxJugador1 = random.Next(0,9);
            int randomyJugador1 = random.Next(0,9);
            jugador1 += tabler[randomyJugador1][randomxJugador1];
            Console.WriteLine($"Jugador 1 tira a ({randomxJugador1},{randomyJugador1}) - {jugador1}");



            int randomxJugador2 = random.Next(0,9);
            int randomyJugador2 = random.Next(0,9);
            jugador2 += tabler[randomyJugador2][randomxJugador2];
            Console.WriteLine($"Jugador 2 tira a ({randomxJugador2},{randomyJugador2}) - {jugador2}");
        }

    }
}
