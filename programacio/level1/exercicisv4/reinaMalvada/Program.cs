namespace reinaMalvada;

class Program
{
    public struct Taula
    {
        public int capacitat {get; set;}
    }
    public struct Persona
    {
        public int quantitatPersones {get;set;}
        public int minutsPersones {get;set;}
    }
    static void Main(string[] args)
    {

        List<Taula> taules = [
            new Taula { capacitat = 2 },
            new Taula { capacitat = 5 }
        ];
        List<Persona> persones = [
            new Persona{ quantitatPersones = 3, minutsPersones = 62 },
            new Persona{ quantitatPersones = 2, minutsPersones = 20 },
            new Persona{ quantitatPersones = 4, minutsPersones = 50 },
            new Persona{ quantitatPersones = 1, minutsPersones = 20 }
        ];
        List<int> minutsPersones = [62, 20, 50, 20];

        taules.Add(new Taula { capacitat = 2 });
        int minuts = 0;
        while ()
        {
            // TODO: process the queue here
        }

    }
}
