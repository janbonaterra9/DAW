var nom = "Filomeno";

var llargada = nom.Length;

for(int i=0; i < llargada; i++)
{
  Console.Write(nom[i]);
}

Console.WriteLine("\n-------------------");



foreach(var lletra in nom)
{
  Console.Write(lletra);
}

Console.WriteLine("\n-------------------");


int index = 0;


while(index > llargada) {

  Console.Write(nom[index]);
  index++;
}
