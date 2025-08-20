using System;
class HelloWorld
{

    public struct produto
    {
        public string Nome;
        public string Codigo;
        public float Preco;
        public int Quantidade;
    }
    static void Main()
    {
        produto[] estoque = new produto[3];
        Console.WriteLine("Insira os dados dos produtos:");
        for (int i = 0; i < 3; i++)
        {

            Console.Write("Nome:");
            string n = Console.ReadLine();
            Console.Write("Código:");
            string c = Console.ReadLine();
            Console.Write("Preço:");
            float p = float.Parse(Console.ReadLine());
            Console.Write("Quantidade:");
            int q = int.Parse(Console.ReadLine());
            estoque[i] = new produto { Nome = n, Codigo = c, Preco = p, Quantidade = q };
            if (i != 3)
            {
                Console.WriteLine("Próximo produto:");
            }

        }

        float valorTotal = 0;

        foreach (produto tal in estoque)
        {

            valorTotal += tal.Preco * tal.Quantidade;
        }

        Console.WriteLine($"O valor total em estoque é de: R${valorTotal}");

    }
}