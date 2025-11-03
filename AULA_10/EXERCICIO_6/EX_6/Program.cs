using System;
using System.Collections.Generic;

// Classe Livro
public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }

    public Livro(string titulo, string autor, int anoPublicacao)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
    }
}

// Classe Biblioteca
public class Biblioteca
{
    public List<Livro> Livros { get; set; }

    public Biblioteca()
    {
        Livros = new List<Livro>();
    }

    public void AdicionarLivro(Livro livro)
    {
        Livros.Add(livro);
        Console.WriteLine($"Livro '{livro.Titulo}' adicionado à biblioteca!");
    }

    public void ListarLivros()
    {
        Console.WriteLine("\n=== Livros na Biblioteca ===");
        
        if (Livros.Count == 0)
        {
            Console.WriteLine("Nenhum livro cadastrado.");
            return;
        }

        for (int i = 0; i < Livros.Count; i++)
        {
            Livro livro = Livros[i];
            Console.WriteLine($"{i + 1}. {livro.Titulo} - {livro.Autor} ({livro.AnoPublicacao})");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Biblioteca ===");
        
        Biblioteca biblioteca = new Biblioteca();
        
        while (true)
        {
            Console.WriteLine("\n1 - Adicionar Livro");
            Console.WriteLine("2 - Listar Livros");
            Console.WriteLine("3 - Sair");
            Console.Write("Opção: ");
            
            string opcao = Console.ReadLine();
            
            if (opcao == "1")
            {
                Console.Write("Título: ");
                string titulo = Console.ReadLine();
                Console.Write("Autor: ");
                string autor = Console.ReadLine();
                Console.Write("Ano de Publicação: ");
                int ano = int.Parse(Console.ReadLine());
                
                Livro livro = new Livro(titulo, autor, ano);
                biblioteca.AdicionarLivro(livro);
            }
            else if (opcao == "2")
            {
                biblioteca.ListarLivros();
            }
            else if (opcao == "3")
            {
                break;
            }
        }
    }
}