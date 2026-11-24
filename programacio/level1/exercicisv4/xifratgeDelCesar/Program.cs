namespace xifratgeDelCesar;

class Program
{
    static void Main(string[] args)
    {
        string abecedari = File.ReadAllText("abecedari.txt");
        string text = File.ReadAllText("text.txt");
        string textConvertit = "";
        text = text.ToUpper();

        int desplacament = 4;

        for(int i=0; i<text.Length; i++)
        {
            if(text[i] == ' ')
            {
                textConvertit+= " ";
            } else
            {
                textConvertit+= $"{LletraAConvertir(text[i], abecedari, desplacament)}";
            }
        }
        File.WriteAllText("textConvertit.txt", textConvertit);
        
    }
    static char LletraAConvertir(char lletra, string abecedari, int desplacament)
    {
        for(int i=0; i<abecedari.Length; i++)
        {
            if(abecedari[i] == lletra)
            {
                return abecedari[i+4];
            }
        }
        return ' ';
    }
}
