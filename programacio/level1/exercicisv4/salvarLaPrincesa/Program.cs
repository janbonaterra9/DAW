namespace salvarLaPrincesa;

class Program
{
        struct Pagesos
        {
            public int Llança {get; set;}
            public int Espasa {get;set;}
        }

        struct Soldats
        {
            public int Casc {get; set;}
            public int Espasa {get;set;}
            public int Escut {get;set;}
        }

        struct Cavallers
        {
            public int Casc {get; set;}
            public int Llança {get;set;}
            public int Escut {get;set;}
            public int Armadura {get;set;}
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
                    pagesos.Llança++;
                    cavallers.Llança++;
                    break;
                case "Espasa":
                    pagesos.Espasa++;
                    soldats.Espasa++;
                    break;
                case "Casc":
                    soldats.Casc++;
                    cavallers.Casc++;
                    break;
                case "Escut":
                    soldats.Escut++;
                    cavallers.Escut++;
                    break;
                case "Armadura":
                    cavallers.Armadura++;
                    break;
            }
        }
        int caballersEnviats = VeureQuinEsElNumeroDeCavallers(cavallers);
        soldats.Casc -= caballersEnviats;
        pagesos.Llança -= caballersEnviats;
        soldats.Escut -= caballersEnviats;
        cavallers.Casc -= caballersEnviats;
        cavallers.Llança -= caballersEnviats;
        cavallers.Armadura -= caballersEnviats;
        cavallers.Escut -= caballersEnviats;

        int soldatsEnviats = VeureQuinEsElNumeroDeSoldats(soldats);
        pagesos.Espasa -= soldatsEnviats;
        soldats.Espasa -= soldatsEnviats;
        soldats.Casc -= soldatsEnviats;
        soldats.Escut -= soldatsEnviats;

        int pagesosEnviats = pagesos.Espasa + pagesos.Llança;

        Console.WriteLine("Es pot enviar:");
        Console.WriteLine($"    Pagesos: {pagesosEnviats}");
        Console.WriteLine($"    Soldats: {soldatsEnviats}");
        Console.WriteLine($"    Cavallers: {caballersEnviats}");
        
    }

  private static int VeureQuinEsElNumeroDeCavallers(Cavallers cavallers)
  {
    int mesPetit = cavallers.Casc;

    if(mesPetit > cavallers.Llança)
        {
            mesPetit = cavallers.Llança;
        }
    if(mesPetit> cavallers.Escut)
        {
            mesPetit = cavallers.Escut;
        }
    if(mesPetit > cavallers.Armadura)
        {
            mesPetit = cavallers.Armadura;
        }
    return mesPetit;
  }
  static int VeureQuinEsElNumeroDeSoldats(Soldats soldats)
    {
        var mesPetit = soldats.Casc;

        if(mesPetit > soldats.Espasa)
        {
            mesPetit = soldats.Espasa;
        }
        if(mesPetit > soldats.Escut)
        {
            mesPetit = soldats.Escut;
        }

        return mesPetit;
    }
}
