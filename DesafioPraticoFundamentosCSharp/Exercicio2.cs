namespace DesafioPraticoFundamentosCSharp;

/** 
 * Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.
 */

public class Exercicio2
{
    public Exercicio2()
    {
        Console.WriteLine("##################################################");
        Console.WriteLine("Digite seu primeiro: ");
        var nome = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome: ");
        var sobrenome = Console.ReadLine();
        Console.WriteLine($"Seu nome completo é: {nome} {sobrenome}");
        Console.WriteLine("##################################################");
    }
}
