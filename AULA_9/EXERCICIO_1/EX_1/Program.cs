Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("-----------------------------");
Console.WriteLine("|                           |");
Console.WriteLine("|         LPR AULA 9        |");
Console.WriteLine("|                           |");
Console.WriteLine("-----------------------------");
Console.ResetColor();


Console.Write("Digite a quantidade de nomes a serem gerados: ");
int x = int.Parse(Console.ReadLine());

List<string> nomes = new List<string>();
Random rand = new Random();

for (int i = 0; i < x; i++)
{
    nomes.Add(GerarNomeAleatorio(rand));
}

Console.WriteLine("\nNomes gerados:");
foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}

Dictionary<int, Queue<string>> nomesPorTamanho = new Dictionary<int, Queue<string>>();
foreach (string nome in nomes)
{
    int len = nome.Length;
    if (!nomesPorTamanho.ContainsKey(len))
        nomesPorTamanho[len] = new Queue<string>();

    nomesPorTamanho[len].Enqueue(nome);
}

List<int> tamanhosOrdenados = nomesPorTamanho.Keys.OrderBy(t => t).ToList();

Console.WriteLine("\nSaída organizada:");
bool aindaTem = true;
while (aindaTem)
{
    aindaTem = false;
    List<string> linha = new List<string>();

    foreach (int tam in tamanhosOrdenados)
    {
        if (nomesPorTamanho[tam].Count > 0)
        {
            linha.Add(nomesPorTamanho[tam].Dequeue());
            aindaTem = true;
        }
    }

    if (linha.Count > 0)
        Console.WriteLine(string.Join(" ", linha));
}



static string GerarNomeAleatorio(Random rand)
{
string[] silabas = { "la", "mi", "ro", "ta", "sa", "na", "ki", "jo", "lu", "ve", "da", "zi" };
int tamanho = rand.Next(2, 4); 
string nome = "";
for (int i = 0; i < tamanho; i++)
{
    nome += silabas[rand.Next(silabas.Length)];
}


return char.ToUpper(nome[0]) + nome.Substring(1);
}

