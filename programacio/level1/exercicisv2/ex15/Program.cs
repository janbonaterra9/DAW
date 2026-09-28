Console.WriteLine("Triangles correctes i incorrectes");

Console.Write("Costat 1: ");
var fcostat1 = Console.ReadLine();
var costat1 = Convert.ToDouble(fcostat1);

Console.Write("Costat 2: ");
var fcostat2 = Console.ReadLine();
var costat2 = Convert.ToDouble(fcostat2);

Console.Write("Costat 3: ");
var fcostat3 = Console.ReadLine();
var costat3 = Convert.ToDouble(fcostat3);

var resultat = comprovarTriangle();

string comprovarTriangle()
{
  if (costat1 > costat2 + costat3 || costat2 > costat1 + costat3 || costat3 > costat2 + costat1)
  {
    return "Aquest triangle no és correcte";
  } else if (costat1 == costat2 && costat1 == costat3)
  {
    return "El triangle és equilater.";
  }
   else if (costat1 == costat2 || costat1 == costat3 || costat2 == costat3)
  {
    return "El triangle és isòsceles.";
  }
  return "El triangle és escalè";
}

Console.WriteLine(resultat);