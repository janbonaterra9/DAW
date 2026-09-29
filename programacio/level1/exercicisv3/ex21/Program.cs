Console.WriteLine("La més curta i la més llarga");
Console.WriteLine();

Console.Write("Quantes paraules? ");
var fparaules = Console.ReadLine();
int paraules = Convert.ToInt32(fparaules);

int gran = -1;
string paraulaGran = "";
int curta = 999999999;
string paraulaCurta = "";

for(int i=1; i<=paraules; i++)
{
  Console.Write($"Paraula {i}: ");
  var paraula = Console.ReadLine();

  if(paraula.Length > gran)
  {
    gran = paraula.Length;
    paraulaGran = paraula;
  }
  if (paraula.Length < curta)
  {
    curta = paraula.Length;
    paraulaCurta = paraula;
  }
}

Console.WriteLine($"La paraula més curta és: {paraulaCurta}");
Console.WriteLine($"La paraula més llarga és: {paraulaGran}");