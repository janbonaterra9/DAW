Console.Write("Entra la seva data sense formatar:");
var data = Console.ReadLine();

var ldata = data.Length;

Console.WriteLine($"La data és: {data[0..2]}/{data[2..4]}/{data[4..8]}");