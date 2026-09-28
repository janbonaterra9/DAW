Console.WriteLine("Entra la teva data de naixament:");
Console.Write("Dia: ");
var fdia = Console.ReadLine();
var dia = Convert.ToInt32(fdia);
Console.Write("Mes: ");
var fmes = Console.ReadLine();
var mes = Convert.ToInt32(fmes);
Console.Write("Any: ");
var fany = Console.ReadLine();
var any = Convert.ToInt32(fany);

var avui = DateTime.Now;
var favuiAny = avui.Year;
var avuiAny = Convert.ToInt32(favuiAny);
var favuiMes = avui.Month;
var avuiMes = Convert.ToInt32(favuiMes);
var favuiDia = avui.Day;
var avuiDia = Convert.ToInt32(favuiDia);

var resposta = calculNaixament(any,mes,dia);

string calculNaixament(int any,int mes, int dia)
{
  if(avuiMes < mes)
  {
    return $"Tens {avuiAny - any - 1} anys";
  } else if (avuiMes == mes && avuiDia < dia)
  {
    return $"Tens {avuiAny - any - 1} anys";
  }
  return $"Tens {avuiAny - any} anys";
}


Console.WriteLine(resposta);