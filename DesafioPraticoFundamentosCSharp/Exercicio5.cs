using System.ComponentModel;

namespace DesafioPraticoFundamentosCSharp;

/** 
Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
- A placa deve ter 7 caracteres alfanuméricos;
- Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
- Os quatro últimos caracteres são números;
Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário. 
*/

public class Exercicio5
{
    public Exercicio5()
    {
        Console.WriteLine("##################################################");
        Console.WriteLine("Digite a placa: ");
        string palavra = Console.ReadLine();
        int total = palavra.Length;
        int totalLetras = 0;
        int totalNumeros = 0;
        foreach (var item in palavra)
        {
            if (char.IsDigit(item)) totalNumeros++;
            if (char.IsLetter(item)) totalLetras++;
        }
        Console.WriteLine(total == 7 && totalLetras == 3 && totalNumeros == 4 ? "VÁLIDA" : "INVÁLIDA");
        Console.WriteLine("##################################################");
    }
}
