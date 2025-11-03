using System;

public class Program {
    public static void Main(string[] args) {
        Aluno aluno = new Aluno("123456", "João", 9.0, 8.0, 7.0);
        Console.WriteLine("Média: " + aluno.Media());
        Console.WriteLine("Prova final: " + aluno.ProvaFinal());
    }
}
public class Aluno
{
    private string matricula;
    private string nome;
    private double prova1;
    private double prova2;
    private double trabalho;

    public Aluno(string matricula, string nome, double prova1, double prova2, double trabalho)
    {
        this.matricula = matricula;
        this.nome = nome;
        this.prova1 = prova1;
        this.prova2 = prova2;
        this.trabalho = trabalho;
    }

    public double Media()
    {
        return (prova1 * 2.5 + prova2 * 2.5 + trabalho * 2.0) / 7.0;
    }

    public double ProvaFinal()
    {
        double mediaAluno = Media();
        if (mediaAluno >= 7.0)
        {
            return 0.0;
        }
        return 7.0 - mediaAluno;
    }
} 