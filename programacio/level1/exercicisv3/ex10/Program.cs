Console.Write("Primera frase: ");
var frase1 = Console.ReadLine();

Console.Write("Segona frase: ");
var frase2 = Console.ReadLine();

int posicio = 0;
bool correcte = true;

for (int i = 0; i < frase1.Length; i++)
{
    bool trobada = false;

    for (int j = posicio; j < frase2.Length; j++)
    {
        if (frase1[i] == frase2[j])
        {
            trobada = true;
            posicio = j + 1;
            break;
        }
    }

    if (!trobada)
    {
        correcte = false;
        break;
    }
}

if (correcte)
{
    Console.WriteLine("Si");
}
else
{
    Console.WriteLine("No");
}