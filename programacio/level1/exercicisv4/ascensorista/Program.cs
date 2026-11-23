using Microsoft.VisualBasic;

namespace ascensorista;

class Program
{
    public struct Robatoris {
        public int planta {get; set;}
        public bool haParat {get; set;}
    }
    static void Main(string[] args)
    {
        try
        {
            string moviments = File.ReadAllText("ascensorista01.txt");
            List<Robatoris> lladre = [
                new Robatoris {planta = 1, haParat = false},
                new Robatoris {planta = 29, haParat = false}
            ];

            int index = 0;
            int planta = 0;
            while(index < moviments.Length && HaParatALesDosPlantes(lladre))
            {
                if(moviments[index] == 'U')
                {
                    planta++;
                } else if (moviments[index] == 'D')
                {
                    planta--;
                }

                if(moviments[index] == '*')
                {
                    for(int i=0; i<lladre.Count; i++)
                    {
                        if(planta == lladre[i].planta)
                        {
                            lladre[i].haParat = true;
                        }
                    }
                }
            }
        } catch (IOException)
        {
            Console.WriteLine("Error al llegir el document");
        }

    }
    static bool HaParatALesDosPlantes(List<Robatoris> lladre)
    {
        for(int i=0; i<lladre.Count;i++)
        {
            if(lladre[i].haParat == false)
            {
                return true;
            }
        }
        return false;
    }
}
