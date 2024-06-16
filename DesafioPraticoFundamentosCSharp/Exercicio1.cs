namespace DesafioPraticoFundamentosCSharp;

/*
1. Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas 
personalizada com o nome dele é exibida:  
**`Olá, Welisson! Seja muito bem-vindo!`**

*Obs: veja que o método para ler os dados que um usuário digita não foi passado em aula.* 
O que acha de começar com a sua primeira busca?

Caso não encontre, vou deixar uma dica aqui embaixo! 
- Dica: O método para ler os dados que um usuário digita é o Console.ReadLine();
*/

public class Exercicio1
{
    public Exercicio1()
    {
        Console.WriteLine("##################################################");
        Console.WriteLine("Informe seu nome: ");
        var nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo(a)!");
        Console.WriteLine("##################################################");
    }
}
