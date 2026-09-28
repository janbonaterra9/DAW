Console.Write("Caràcter: ");
var fcaracter = Console.ReadLine();
var caracter = Convert.ToChar(fcaracter);

var resultat = comprovarCaracter(caracter);
Console.WriteLine(resultat);

string comprovarCaracter(char caracter)
{
  if(caracter >= '0' && caracter <= '9')
  {
    return "És un numero";
  } 
  else if(caracter >= 'a' && caracter <= 'z') {
    return "És una minúscula";
  }
  else if(caracter >= 'A' && caracter <= 'Z')
  {
    return "És una majúscula";
  }
  return "No és ni lletra ni número";
}