using System;

class Program
{
    static void Main()
    {
        int escolha;

        do
        {
            Console.WriteLine("Escolha a classe do seu personagem:");
            Console.WriteLine("1 - Guerreira");
            Console.WriteLine("2 - Mago");
            Console.WriteLine("3 - Arqueira");

            string entrada = Console.ReadLine();

            bool isNumeroValido = int.TryParse(entrada, out escolha);

            if (!isNumeroValido || escolha < 1 || escolha > 3)
            {
                Console.WriteLine("Opção inválida! Por favor, escolha uma opção válida.");
            }
            else
            {
               
                break;
            }

        } while (true); 


        switch (escolha)
        {
            case 1:
                Console.WriteLine("Você escolheu a classe Guerreira!");
                Console.WriteLine("Habilidades Especiais:");
                Console.WriteLine("- Ataque Pesado");
                Console.WriteLine("- Defesa Total");
                break;

            case 2:
               
                Console.WriteLine("Você escolheu a classe Mago!");
                Console.WriteLine("Habilidades Especiais:");
                Console.WriteLine("- Bola de Fogo");
                Console.WriteLine("- Escudo de Gelo");
                break;

            case 3:
              
                Console.WriteLine("Você escolheu a classe Arqueira!");
                Console.WriteLine("Habilidades Especiais:");
                Console.WriteLine("- Flecha Precisa");
                Console.WriteLine("- Disparo Triplo");
                break;
        }

        
  
    }
}
