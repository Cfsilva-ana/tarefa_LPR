using System;
using System.Collections.Generic;

// Classe Matricula (intermediária)
public class Matricula
{
    public Aluno Aluno { get; set; }
    public Turma Turma { get; set; }
    public DateTime DataMatricula { get; set; }

    public Matricula(Aluno aluno, Turma turma, DateTime dataMatricula)
    {
        Aluno = aluno;
        Turma = turma;
        DataMatricula = dataMatricula;
    }
}

// Classe Aluno
public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public List<Matricula> Matriculas { get; set; }

    public Aluno(int id, string nome)
    {
        Id = id;
        Nome = nome;
        Matriculas = new List<Matricula>();
    }

    public bool AdicionarMatricula(Turma turma, DateTime dataMatricula)
    {
        // Verifica se já está matriculado na turma
        foreach (Matricula m in Matriculas)
        {
            if (m.Turma.Id == turma.Id)
            {
                Console.WriteLine($"{Nome} já está matriculado na turma {turma.Nome}!");
                return false;
            }
        }

        Matricula matricula = new Matricula(this, turma, dataMatricula);
        Matriculas.Add(matricula);
        turma.Matriculas.Add(matricula);
        Console.WriteLine($"{Nome} matriculado na turma {turma.Nome}!");
        return true;
    }
}

// Classe Turma
public class Turma
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public List<Matricula> Matriculas { get; set; }

    public Turma(int id, string nome)
    {
        Id = id;
        Nome = nome;
        Matriculas = new List<Matricula>();
    }

    public bool AdicionarMatricula(Aluno aluno, DateTime dataMatricula)
    {
        // Verifica se o aluno já está matriculado
        foreach (Matricula m in Matriculas)
        {
            if (m.Aluno.Id == aluno.Id)
            {
                Console.WriteLine($"{aluno.Nome} já está matriculado na turma {Nome}!");
                return false;
            }
        }

        Matricula matricula = new Matricula(aluno, this, dataMatricula);
        Matriculas.Add(matricula);
        aluno.Matriculas.Add(matricula);
        Console.WriteLine($"{aluno.Nome} matriculado na turma {Nome}!");
        return true;
    }

    public List<Aluno> ListarAlunos()
    {
        List<Aluno> alunos = new List<Aluno>();
        foreach (Matricula m in Matriculas)
        {
            alunos.Add(m.Aluno);
        }
        return alunos;
    }

    public void ExibirAlunos()
    {
        Console.WriteLine($"\nAlunos da turma {Nome}:");
        if (Matriculas.Count == 0)
        {
            Console.WriteLine("Nenhum aluno matriculado.");
            return;
        }

        foreach (Matricula m in Matriculas)
        {
            Console.WriteLine($"- {m.Aluno.Nome} (Matrícula: {m.DataMatricula:dd/MM/yyyy})");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Matrícula ===");

        // Criando alunos
        Aluno aluno1 = new Aluno(1, "João Silva");
        Aluno aluno2 = new Aluno(2, "Maria Santos");
        Aluno aluno3 = new Aluno(3, "Pedro Costa");

        // Criando turmas
        Turma turma1 = new Turma(1, "Matemática");
        Turma turma2 = new Turma(2, "Português");

        // Testando matrículas
        DateTime hoje = DateTime.Now;
        
        // Matriculando alunos
        aluno1.AdicionarMatricula(turma1, hoje);
        aluno1.AdicionarMatricula(turma2, hoje);
        aluno2.AdicionarMatricula(turma1, hoje);
        aluno3.AdicionarMatricula(turma2, hoje);

        // Tentativa de matrícula duplicada
        aluno1.AdicionarMatricula(turma1, hoje);

        // Exibindo alunos por turma
        turma1.ExibirAlunos();
        turma2.ExibirAlunos();
    }
}