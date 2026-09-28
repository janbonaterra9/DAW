Console.WriteLine("Pedra, paper, tisores");
Console.Write("Jugador 1: ");
var jugador1 = Console.ReadLine();
Console.Write("Jugador 2: ");
var jugador2 = Console.ReadLine();

if (jugador1 != null && jugador2 != null)
{
  
var resposta = comprovarGuanyador(jugador1, jugador2);

string comprovarGuanyador(string jugador1, string jugador2)
{
  if (jugador1 == jugador2)
    {
      return "No guanya ningú";
    } else if (jugador1 == "pedra" && jugador2 == "tisores")
    {
      return "Ha guanyat el jugador 1";
    } else if (jugador1 == "tisores" && jugador2 == "paper")
    {
      return "Ha guanyat el jugador 1";
    } else if (jugador1 == "paper" && jugador2 == "pedra")
    {
      return "Ha guanyat el jugador 1";
    } else if (jugador1 == "pedra" && jugador2 == "paper")
    {
      return "Ha guanyat el jugador 2";
    } else if (jugador1 == "paper" && jugador2 == "tisores")
    { 
      return "Ha guanyat el jugador 2";
    } else if (jugador1 == "tisores" && jugador2 == "pedra")
    {
      return "Ha guanyat el jugador 2";
    }
  return "error :)";
}


Console.WriteLine(resposta);

} else
{
  Console.WriteLine("No has entrat cap jugada");
}