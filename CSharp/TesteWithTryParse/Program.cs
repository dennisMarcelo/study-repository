/*
     O método TryParse() faz várias coisas simultaneamente:
        - Ele tenta analisar uma cadeia de caracteres sobre o tipo de dados numérico fornecido.
        - Se for bem-sucedido, ele armazenará o valor convertido em um parâmetro out.
        - Ele retorna um bool para indicar se a ação foi bem-sucedida ou falhou.
*/

namespace TesteWithTryParse;

class Program
{
    public static void Main()
    {
        string[] values = { "12,3", "45", "ABC", "11", "DEF" };

        string stringConcatenated = "";
        float numberSomed = 0;

        foreach(var value in values)
        {
            if (float.TryParse(value, out float result))
                numberSomed += result;
            else
                stringConcatenated += value;
        }

        Console.WriteLine($"Message: {stringConcatenated}");
        Console.WriteLine($"Total: {numberSomed}");

    }
}
