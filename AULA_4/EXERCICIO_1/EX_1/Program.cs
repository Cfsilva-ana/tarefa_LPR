// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("-----------------------------");
Console.WriteLine("|                           |");
Console.WriteLine("|         LPR AULA 4        |");
Console.WriteLine("|                           |");
Console.WriteLine("-----------------------------");
Console.ResetColor();



Console.Write("Insira um número inteiro para verificar se ele é par ou impar: "); 
string Numero_interiro = Console.ReadLine();


    if(!int.TryParse(Numero_interiro, out int numero))
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Entrada inválida!!!!! Encerrando o programa.");
        Console.ResetColor();
        Environment.Exit(0);
    }

    if (numero % 2 == 0)
        Console.WriteLine($"O número {numero} é par.");
    else
        Console.WriteLine($"O número {numero} é ímpar.");
