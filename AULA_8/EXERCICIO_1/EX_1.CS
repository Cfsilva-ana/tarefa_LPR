using System;

public struct Produto
{
    public string Nome;
    public int Codigo;
    public double Preco;
    public int Quantidade;
}

public class GestaoEstoque
{
    public static void Main(string[] args)
    {
        Produto[] produtos = new Produto[3];

        Console.WriteLine("--- CADASTRO DE PRODUTOS ---");

        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine($"\n--- Produto {i + 1} ---");
            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write("Codigo: ");
            produtos[i].Codigo = int.Parse(Console.ReadLine());

            Console.Write("Preco (R$): ");
            produtos[i].Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em estoque: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());
        }

        double valorTotalEstoque = 0;

        foreach (Produto p in produtos)
        {
            valorTotalEstoque += p.Preco * p.Quantidade;
        }

        Console.WriteLine("\n-------------------------------------------------");
        Console.WriteLine($"O valor total em estoque e de: R$ {valorTotalEstoque:F2}");
        Console.WriteLine("-------------------------------------------------");
    }
}