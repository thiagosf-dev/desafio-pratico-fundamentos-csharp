using System.ComponentModel;

namespace DesafioPraticoFundamentosCSharp;

/** 
Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.
- Dica
Você pode fazer uma verificação e incrementar o contador apenas **`se`** for um caractere, ignorando os espaços caso o usuário digite mais que uma palavra, por exemplo.
 */

public class Exercicio4
{
    public Exercicio4()
    {
        Console.WriteLine("##################################################");
        Console.WriteLine("Digite uma palavra: ");
        string palavra = Console.ReadLine();
        int total = 0;
        foreach (var item in palavra)
        {
            if (!item.ToString().Equals(" ")) total++;
        }
        Console.WriteLine($"Total de caracteres: {total}");
        Console.WriteLine("##################################################");
    }
}
