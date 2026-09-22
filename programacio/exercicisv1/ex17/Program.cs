Console.Write("Nota de pràctiques: ");
var practiques = Console.ReadLine();
Console.Write("Nota de exàmens: ");
var examens = Console.ReadLine();

int fpractiques = Convert.ToInt32(practiques);
int fexamens = Convert.ToInt32(examens);

double mitjanaPractiques = fpractiques * 0.2;
double mitjanaExamens = fexamens * 0.8;

var notaFinal = mitjanaPractiques + mitjanaExamens;

Console.WriteLine($"La nota final és: {notaFinal}, o sigui un {(int)notaFinal}");