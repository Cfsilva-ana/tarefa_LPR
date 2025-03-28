/*WHILE: Construa um algoritmo que calcule a
média aritmética de um conjunto de números
pares fornecidos pelo usuário. O usuário deve
fornecer primeiro a quantidade de números que
serão digitados, e em seguida, os números
considerados na média. O usuário pode digitar
números ímpares, que devem ser ignorados.
Por exemplo, no caso da tabela abaixo, o 5
informa que serão digitados 5 números (2 7 8 6
10), e para a média devem ser considerados
apenas os números pares (2, 8, 6 e 10)
ignorando o número 7 digitado.
*/

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("-----------------------------");
Console.WriteLine("|                           |");
Console.WriteLine("|         LPR AULA 5        |");
Console.WriteLine("|                           |");
Console.WriteLine("-----------------------------");
Console.ResetColor();



Console.Write("Quantos números deseja inserir? ");
int quantidade;

while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
{
    Console.WriteLine("Entrada inválida! Digite um número inteiro e positivo.");
    Console.Write("Quantos números deseja inserir? ");
}

double soma = 0;
int Pares = 0;
int j = 0;

while (j < quantidade)
{
    Console.Write($"Digite o {j + 1}º número: ");
    double numero;

    if (double.TryParse(Console.ReadLine(), out numero))
    {
        if (numero % 2 == 0) // Verifica se é par
        {
            soma += numero;
            Pares++;
        }
        j++; 
    }
    else
    {
        Console.WriteLine("Entrada inválida! Digite um número válido.");
    }
}

if (Pares > 0)
{
    double media = soma / Pares;
    Console.WriteLine($"A média dos números pares é: {media:F2}");
}
else
{
    Console.WriteLine("Nenhum número par foi digitado.");
}
