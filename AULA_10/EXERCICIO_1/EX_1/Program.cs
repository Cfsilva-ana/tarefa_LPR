using System;

class Retangulo
{
    public double Altura { get; set; }
    public double Largura { get; set; }

    public double calcArea()
    {
        return Largura * Altura;
    }

    public double calcPerimetro()
    {
        return 2 * (Largura + Altura);
    }
}

class Program
{
    static void Main()
    {
        Retangulo retangulo = new Retangulo();

        Console.Write("Digite a largura do retângulo: ");
        retangulo.Largura = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura do retângulo: ");
        retangulo.Altura = double.Parse(Console.ReadLine());

        Console.WriteLine($"Área: {retangulo.calcArea():F2}");
        Console.WriteLine($"Perímetro: {retangulo.calcPerimetro():F2}");
    }
}
