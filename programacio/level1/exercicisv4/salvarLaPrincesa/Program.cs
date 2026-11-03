using System.Linq.Expressions;

namespace salvarLaPrincesa;

class Program
{
        struct Pagesos
        {
            public int llança {get; set;}
            public int espasa {get;set;}
        }

        struct Soldats
        {
            public int casc {get; set;}
            public int espasa {get;set;}
            public int escut {get;set;}
        }

        struct Cavallers
        {
            public int casc {get; set;}
            public int llança {get;set;}
            public int escut {get;set;}
            public int armadura {get;set;}
        }


    static void Main(string[] args)
    {
        Pagesos pagesos = new Pagesos();
        Soldats soldats = new Soldats();
        Cavallers cavallers = new Cavallers();
        string[] armes = {
        "Casc", "Casc", "Escut", "Llança", "Llança", "Escut", "Escut", "Espasa", "Escut",
        "Escut", "Casc", "Casc", "Casc", "Escut", "Escut", "Escut", "Espasa", "Escut",
        "Espasa", "Escut", "Escut", "Espasa", "Espasa", "Llança", "Escut", "Escut",
        "Casc", "Espasa", "Armadura", "Espasa", "Espasa", "Escut", "Escut", "Armadura",
        "Armadura", "Espasa", "Espasa", "Espasa", "Casc", "Escut", "Llança", "Casc",
        "Llança", "Escut", "Espasa", "Armadura", "Llança", "Escut", "Espasa", "Espasa",
        "Escut", "Escut", "Llança", "Casc", "Casc", "Escut", "Casc", "Espasa", "Casc",
        "Espasa", "Espasa", "Espasa", "Escut", "Casc", "Espasa", "Armadura", "Casc",
        "Espasa", "Espasa", "Llança", "Espasa", "Espasa", "Casc", "Casc", "Escut", "Casc",
        "Casc", "Armadura", "Llança", "Escut", "Armadura", "Espasa", "Armadura", "Escut",
        "Casc", "Espasa", "Casc", "Escut", "Escut", "Espasa", "Armadura", "Armadura",
        "Llança", "Llança", "Armadura", "Casc", "Casc", "Espasa", "Llança", "Espasa",
        "Armadura", "Espasa", "Espasa", "Llança", "Escut", "Casc", "Casc", "Llança",
        "Casc", "Llança", "Escut", "Espasa", "Escut", "Espasa", "Escut", "Llança",
        "Llança", "Llança", "Llança", "Casc", "Espasa", "Armadura", "Casc", "Escut",
        "Llança", "Llança", "Armadura", "Espasa", "Escut", "Casc", "Casc", "Casc",
        "Espasa", "Espasa", "Armadura", "Casc", "Escut", "Espasa", "Casc", "Armadura",
        "Armadura", "Espasa", "Casc", "Escut", "Espasa", "Espasa", "Escut", "Escut",
        "Escut", "Escut",
        };

        for(int i= 0; i<armes.Length;i++)
        {
            switch(armes[i])
            {
                case "Llança":
                    pagesos.llança++;
                    cavallers.llança++;
                    break;
                case "Espasa":
                    pagesos.espasa++;
                    soldats.espasa++;
                    break;
                case "Casc":
                    soldats.casc++;
                    cavallers.casc++;
                    break;
                case "Escut":
                    soldats.escut++;
                    cavallers.escut++;
                    break;
                case "Armadura":
                    cavallers.armadura++;
                    break;
            }
        }

        Console.WriteLine("Es pot enviar:")
    }
}
