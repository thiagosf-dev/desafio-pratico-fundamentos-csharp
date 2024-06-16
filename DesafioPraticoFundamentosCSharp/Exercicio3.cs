using System.ComponentModel;

namespace DesafioPraticoFundamentosCSharp;

/** 
1. Crie um programa com 2 valores do tipo double já declarados que retorne:
- A soma entre esses dois números;
- A subtração entre os dois números;
- A multiplicação entre os dois números;
- A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
- A média entre os dois números.
Você pode ir além e permitir que o usuário insira dois números aleatórios!
 */

public class Exercicio3
{
    public Exercicio3()
    {
        Console.WriteLine("##################################################");
        Console.WriteLine("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"SOMA: {numero1 + numero2}");
        Console.WriteLine($"SUBTRAÇÃO: {numero1 - numero2}");
        Console.WriteLine($"MULTIPLICAÇÃO: {numero1 * numero2}");
        Console.WriteLine($"DIVISÃO: {(numero2 == 0 ? 0 : numero1 / numero2)}");
        Console.WriteLine($"MÉDIA: {(numero1 + numero2) / 2}");
        Console.WriteLine("##################################################");
    }
}
