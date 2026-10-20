namespace teseuILaberint;

class Program
{
    static void Main(string[] args)
    {
        string[][] laberint = [
            ["#","#","#","#","#","#","#","#","#","#"],
            ["#","·","·","·","·","·","·","·","·","#"],
            ["#","·","·","H","·","·","·","·","·","#"],
            ["#","·","·","·","·","·","·","·","·","#"],
            ["#","·","·","·","·","·","·","·","S","#"],
            ["#","#","#","#","#","#","#","#","#","#"]
        ];

        int heroiY = -1;
        int heroiX = -1;
        int sortidaY = -1;
        int sortidaX = -1;

        for(int i=0; laberint.Length > i; i++)
        {
            Console.WriteLine();
            for(int j=0; laberint[i].Length > j; j++)
            {
                Console.Write(laberint[i][j]);
                if(laberint[i][j] == "H" || laberint[i][j] == "h")
                {
                    heroiY = i;
                    heroiX = j;
                }
                if (laberint[i][j] == "s" || laberint[i][j] == "S")
                {
                    sortidaX =j;
                    sortidaY = i;
                }
            }
        }

        int distancia = (heroiX - sortidaX ) + (heroiY - sortidaY);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Heroi: fila {heroiY}, columna {heroiX}");
        Console.WriteLine($"Sortida: fila {sortidaY}, columna {sortidaX}");
        Console.WriteLine();
        Console.WriteLine($"Distàcia entre l'heroi i la sortida: {Math.Abs(distancia)} caselles");
        



    }
}
