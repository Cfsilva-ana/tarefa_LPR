/* Exercício 4
A. Desenvolva o diagrama de classes do
seu jogo favorito: pense em
personagens, cenários, coisas utilizadas
pelos personagens, poderes,
habilidades, etc…
○ Dica: utilize um software de desenho.
Sugestão: LucidChart
○ Submeta no questionário da tarefa uma
imagem contendo o diagrama de classes
desenhado
B. Implemente 3 classes principais do seu
jogo (as que você escolher) e submeta
os códigos das classes no questionário*/

// Classe Personagem representa um personagem jogável
public class Personagem
{
    private string nome;
    private int vida;
    private int energia;
    private string arma;
    
    public Personagem(string nome, int vida, int energia, string arma)
    {
        this.nome = nome;
        this.vida = vida;
        this.energia = energia;
        this.arma = arma;
    }
    
    public void Atacar()
    {
        energia -= 10;
    }
    
    public void Curar()
    {
        vida += 20;
    }
}

// Classe Cenario representa um nível/fase do jogo
public class Cenario
{
    private string nome;
    private int dificuldade;
    private bool concluido;
    
    public Cenario(string nome, int dificuldade)
    {
        this.nome = nome;
        this.dificuldade = dificuldade;
        this.concluido = false;
    }
    
    public void IniciarCenario()
    {
        Console.WriteLine("Iniciando cenário: " + nome);
    }
    
    public void ConcluirCenario()
    {
        this.concluido = true;
    }
}

// Classe Item representa itens coletáveis no jogo
public class Item
{
    private string nome;
    private string tipo;
    private int poder;
    
    public Item(string nome, string tipo, int poder)
    {
        this.nome = nome;
        this.tipo = tipo;
        this.poder = poder;
    }
    
    public void Usar()
    {
        Console.WriteLine("Usando item: " + nome);
    }
    
    public void Descartar()
    {
        Console.WriteLine("Item descartado: " + nome);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Jogo RPG - Classes Implementadas");
    }
}
