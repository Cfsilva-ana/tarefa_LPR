Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("-----------------------------");
Console.WriteLine("|                           |");
Console.WriteLine("|         LPR AULA 5        |");
Console.WriteLine("|                           |");
Console.WriteLine("-----------------------------");
Console.ResetColor();


int numero;

// Loop para garantir que o usuário insira um número inteiro válido
while (true)
{
    Console.Write("Digite um número: ");
    string entrada = Console.ReadLine();

    if (int.TryParse(entrada, out numero))
    {
        break; 
    }
    else
    {
        Console.WriteLine("Entrada inválida! Digite apenas números.");
    }
}

// Calcula o quadrado do número
int quadrado = numero * numero;
Console.WriteLine($"O quadrado de {numero} é {quadrado}");

// Calcula a soma dos dígitos do quadrado
int somaDigitos = 0;
int temp = quadrado;

while (temp > 0)
{
    somaDigitos += temp % 10; // Pega o último dígito e soma
    temp /= 10; // Remove o último dígito
}

Console.WriteLine($"A soma dos dígitos de {quadrado} é: {somaDigitos}");

