using System;

[cite_start]// Utiliza STRUCT para armazenar as informações dos heróis [cite: 423]
public struct Heroi
{
    public string Nome;
    public string Poder;
    public int Pontuacao;
}

public class SelecaoMarvel
{
    [cite_start]
    static Heroi[] heroisCadastrados = new Heroi[5];
    static int numHeroisCadastrados = 0;

    [cite_start]
    static Heroi[] equipeSelecionada = new Heroi[3];
    static bool equipeFoiSelecionada = false;

    [cite_start]
    static void CadastrarHeroi()
    {
        if (numHeroisCadastrados >= 5)
        {
            Console.WriteLine("\nLimite de 5 herois atingido! Nao e possivel cadastrar mais.");
            return;
        }

        Console.WriteLine("\n--- CADASTRO DE HEROI ---");
        Heroi novoHeroi = new Heroi();

        Console.Write("Nome do Heroi: ");
        novoHeroi.Nome = Console.ReadLine();

        Console.Write("Poder: ");
        novoHeroi.Poder = Console.ReadLine();

        Console.Write("Pontuacao (0-100): ");
        novoHeroi.Pontuacao = int.Parse(Console.ReadLine());

        heroisCadastrados[numHeroisCadastrados] = novoHeroi;
        numHeroisCadastrados++;

        Console.WriteLine($"\nHeroi {novoHeroi.Nome} cadastrado com sucesso!");
    }

    [cite_start]
    static void SelecionarEquipe()
    {
        if (numHeroisCadastrados < 3)
        {
            Console.WriteLine("\nE necessario ter pelo menos 3 herois cadastrados para formar uma equipe.");
            return;
        }

        Console.WriteLine("\n--- SELECAO DE EQUIPE ---");
        Console.WriteLine("Herois disponiveis:");
        for (int i = 0; i < numHeroisCadastrados; i++)
        {
            Console.WriteLine($"{i}: {heroisCadastrados[i].Nome}");
        }

        Console.WriteLine("\nSelecione 3 herois para sua equipe (digite o numero correspondente):");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Escolha o heroi {i + 1}: ");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha >= 0 && escolha < numHeroisCadastrados)
            {
                equipeSelecionada[i] = heroisCadastrados[escolha];
                Console.WriteLine($"{equipeSelecionada[i].Nome} adicionado a equipe.");
            }
            else
            {
                Console.WriteLine("Escolha invalida. Tente novamente.");
                i--; 
            }
        }
        equipeFoiSelecionada = true;
        Console.WriteLine("\nEquipe selecionada com sucesso!");
    }
    
    [cite_start]
    static int CalcularPontuacaoTotal()
    {
        int pontuacaoTotal = 0;
        foreach (Heroi heroi in equipeSelecionada)
        {
            pontuacaoTotal += heroi.Pontuacao; 
        return pontuacaoTotal;
    }


    [cite_start]
    static void ExibirEquipe()
    {
        if (!equipeFoiSelecionada)
        {
            Console.WriteLine("\nNenhuma equipe foi selecionada ainda. Use a opcao 2.");
            return;
        }

        Console.WriteLine("\n--- SUA EQUIPE DE HEROIS ---");
        foreach (Heroi heroi in equipeSelecionada)
        {
            Console.WriteLine($"Nome: {heroi.Nome}, Poder: {heroi.Poder}");
        }

        int pontuacao = CalcularPontuacaoTotal();
        Console.WriteLine($"\nPONTUACAO TOTAL DA EQUIPE: {pontuacao}");
    }

    [cite_start]
    static void MenuPrincipal()
    {
        Console.WriteLine("\n===== MENU MARVEL =====");
        Console.WriteLine("1. Cadastrar Heroi");
        Console.WriteLine("2. Selecionar Equipe");
        Console.WriteLine("3. Exibir Equipe e Pontuacao Total");
        Console.WriteLine("4. Sair do Programa");
        Console.Write("Escolha uma opcao: ");
    }

    public static void Main(string[] args)
    {
        string opcao;
        
        [cite_start]
        do
        {
            MenuPrincipal();
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarHeroi();
                    break;
                case "2":
                    SelecionarEquipe();
                    break;
                case "3":
                    ExibirEquipe();
                    break;
                case "4":
                    Console.WriteLine("\nEncerrando o programa...");
                    break;
                default:
                    Console.WriteLine("\nOpcao invalida. Tente novamente.");
                    break;
            }
        } while (opcao != "4");
    }
}