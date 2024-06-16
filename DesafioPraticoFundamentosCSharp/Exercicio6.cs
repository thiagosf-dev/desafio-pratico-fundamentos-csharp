using System.ComponentModel;
using System.Globalization;

namespace DesafioPraticoFundamentosCSharp;

/** 
Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
- Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
- Apenas a data no formato "01/03/2024".
- Apenas a hora no formato de 24 horas.
- A data com o mês por extenso. 
*/

public class Exercicio6
{
    public Exercicio6()
    {
        Console.WriteLine("##################################################");
        Console.WriteLine("Qual formato quer ver a data (1-completa 2-apenas data 3-apenas hora 4-data com mês por extenso)? ");
        string data = Console.ReadLine();
        DateTime dataHoraAtual = DateTime.Now;
        string result = data switch
        {
            "1" => dataHoraAtual.ToString("F"),
            "2" => dataHoraAtual.ToString("d"),
            "3" => dataHoraAtual.ToString("HH:mm"),
            _ => dataHoraAtual.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")),
        };
        Console.WriteLine(result);
        Console.WriteLine("##################################################");
    }
}
