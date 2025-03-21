using System;

class Program
{
    static void Main()
    {
        int escolha;

        // Laço para garantir que o jogador faça uma escolha válida
        do
        {
            // Exibe o menu de opções para o jogador escolher uma classe
            Console.WriteLine("Escolha a classe do seu personagem:");
            Console.WriteLine("1 - Guerreira");
            Console.WriteLine("2 - Mago");
            Console.WriteLine("3 - Arqueira");

            // Lê a opção do jogador
            string entrada = Console.ReadLine();

            // Tenta converter a entrada para um número inteiro
            bool isNumeroValido = int.TryParse(entrada, out escolha);

            // Verifica se a entrada é um número válido e dentro do intervalo
            if (!isNumeroValido || escolha < 1 || escolha > 3)
            {
                Console.WriteLine("Opção inválida! Por favor, escolha uma opção válida.");
            }
            else
            {
                // Se a entrada for válida, sai do laço
                break;
            }

        } while (true); // Continua até a entrada ser válida

        // Após uma escolha válida, exibe as habilidades da classe escolhida
        switch (escolha)
        {
            case 1:
                // Classe Guerreira
                Console.WriteLine("Você escolheu a classe Guerreira!");
                Console.WriteLine("Habilidades Especiais:");
                Console.WriteLine("- Ataque Pesado");
                Console.WriteLine("- Defesa Total");
                break;

            case 2:
                // Classe Mago
                Console.WriteLine("Você escolheu a classe Mago!");
                Console.WriteLine("Habilidades Especiais:");
                Console.WriteLine("- Bola de Fogo");
                Console.WriteLine("- Escudo de Gelo");
                break;

            case 3:
                // Classe Arqueira
                Console.WriteLine("Você escolheu a classe Arqueira!");
                Console.WriteLine("Habilidades Especiais:");
                Console.WriteLine("- Flecha Precisa");
                Console.WriteLine("- Disparo Triplo");
                break;
        }

        // Manter a tela aberta após a execução
        Console.ReadLine();
    }
}
