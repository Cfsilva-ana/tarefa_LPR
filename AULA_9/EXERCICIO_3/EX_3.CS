using System;
using System.Collections.Generic;
using System.Linq;

public class AnaliseIdades
{
    public static void Main(string[] args)
    {
        Console.Write("Quantas pessoas deseja cadastrar? ");
        int x = int.Parse(Console.ReadLine());

        var pessoas = new Dictionary<string, int>();
        for (int i = 0; i < x; i++)
        {
            Console.Write($"Digite o nome da pessoa {i + 1}: ");
            string nome = Console.ReadLine();
            Console.Write($"Digite a idade de {nome}: ");
            int idade = int.Parse(Console.ReadLine());
            pessoas.Add(nome, idade); [cite_start]
        }

        if (!pessoas.Any())
        {
            Console.WriteLine("\nNenhuma pessoa cadastrada.");
            return;
        }
        
        double mediaIdade = pessoas.Values.Average();
        Console.WriteLine($"\nA media de idade e: {mediaIdade:F2}");
        var acimaDaMedia = pessoas.Where(p => p.Value > mediaIdade).Select(p => p.Key);
        Console.WriteLine("Pessoas com idade acima da media: " + string.Join(", ", acimaDaMedia));

        var maisVelha = pessoas.Aggregate((l, r) => l.Value > r.Value ? l : r);
        var maisNova = pessoas.Aggregate((l, r) => l.Value < r.Value ? l : r);
        Console.WriteLine($"Pessoa mais velha: {maisVelha.Key} ({maisVelha.Value} anos)");
        Console.WriteLine($"Pessoa mais nova: {maisNova.Key} ({maisNova.Value} anos)");

        Console.Write("\nDigite uma idade para remover todas as pessoas correspondentes: ");
        int idadeParaRemover = int.Parse(Console.ReadLine());
        var chavesParaRemover = pessoas.Where(p => p.Value == idadeParaRemover).Select(p => p.Key).ToList();

        if (chavesParaRemover.Any())
        {
            foreach (var chave in chavesParaRemover)
            {
                pessoas.Remove(chave); [cite_start]
            Console.WriteLine($"Pessoas com {idadeParaRemover} anos foram removidas.");
        }
        else
        {
            Console.WriteLine($"Nenhuma pessoa com {idadeParaRemover} anos encontrada.");
        }

        Console.WriteLine("\nDicionario atualizado:");
        foreach (var pessoa in pessoas)
        {
            Console.WriteLine($" - Nome: {pessoa.Key}, Idade: {pessoa.Value}"); [cite_start]
        }
    }
}