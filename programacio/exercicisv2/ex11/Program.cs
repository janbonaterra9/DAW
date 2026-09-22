using System.Runtime.InteropServices;

Console.WriteLine("El periodista especial");
Console.Write("FC Vilamongat: ");
var fvilamongat = Console.ReadLine();
var vilamongat = Convert.ToInt32(fvilamongat);
Console.Write("UE Fontverda: ");
var ffontverda = Console.ReadLine();
var fontverda = Convert.ToInt32(ffontverda);

var resultat = cronica();

string cronica()
{
  if (vilamongat > fontverda)
  {
    return $"Gran partit del Vilamongat que ha superat a la UE fontverda per {vilamongat} a {fontverda}";
  } else if (vilamongat < fontverda)
  {
    return $"Gran partit de la UE Fontverda que ha superat al FC Vilamongat per {fontverda} a {vilamongat}";
  }
  return $"Partit molt igualat entre els dos rivals que ha acabat en empat {vilamongat} a {fontverda} tot i els esforços dels dos equips";
}

Console.WriteLine(resultat);