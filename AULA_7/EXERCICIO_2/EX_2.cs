using System;
using System.Collections.Generic;

public class Exercicio2
{
    public static void Main(string[] args)
    {
        int[] numeros = new int[10];
        Console.WriteLine("Digite 10 numeros inteiros:");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Numero {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // 2. Solicitar o número para pesquisa.
        Console.Write("\nDigite o numero que deseja pesquisar: ");
        int numeroPesquisado = int.Parse(Console.ReadLine());

        // 3. Encontrar ocorrências e posições.
        List<int> posicoes = new List<int>();
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == numeroPesquisado)
            {
                posicoes.Add(i);
            }
        }

        if (posicoes.Count > 0)
        {
            Console.WriteLine($"\nO numero {numeroPesquisado} foi encontrado {posicoes.Count} vez(es).");
            Console.WriteLine("Ele aparece na(s) seguinte(s) posicao(oes) (indice): " + string.Join(", ", posicoes));
        }
        else
        {
            Console.WriteLine($"\nO numero {numeroPesquisado} nao foi encontrado no vetor.");
        }
    }
}