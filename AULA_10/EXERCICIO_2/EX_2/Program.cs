/*
Exercício 2)
A. Fazer um programa C# para ler os dados
de um funcionário (nome, salário bruto
e imposto).
B. A classe funcionário deve conter os
seguintes métodos:
○ Mostrar os dados do funcionário (nome e
salário líquido).
○ Aumentar o salário do funcionário com base
em uma porcentagem dada
C. OBS: Tabela de Imposto
○ 10% para salários de até 2000
○ 15% para salários de até 3000
○ 20% para salários superiores a 3000
using System;

*/
class Funcionario {
    public string Nome { get; set; }
    public double SalarioBruto { get; set; }
    private double Imposto {
        get {
            if (SalarioBruto <= 2000) return 0.10;
            if (SalarioBruto <= 3000) return 0.15;
            return 0.20;
        }
    }

    public double SalarioLiquido() {
        return SalarioBruto * (1 - Imposto);
    }

    public void AumentarSalario(double porcentagem) {
        SalarioBruto *= (1 + porcentagem/100.0);
    }

    public void MostrarDados() {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Salário Líquido: R$ {SalarioLiquido():F2}");
    }
}

class Program {
    static void Main(string[] args) {
        Funcionario func = new Funcionario();

        Console.Write("Nome do funcionário: ");
        func.Nome = Console.ReadLine();

        Console.Write("Salário bruto: R$ ");
        func.SalarioBruto = double.Parse(Console.ReadLine());

        Console.WriteLine("\nDados do funcionário:");
        func.MostrarDados();

        Console.Write("\nDigite a porcentagem de aumento: ");
        double aumento = double.Parse(Console.ReadLine());
        func.AumentarSalario(aumento);

        Console.WriteLine("\nDados atualizados:");
        func.MostrarDados();
    }
}