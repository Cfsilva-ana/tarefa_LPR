Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("-----------------------------");
Console.WriteLine("|                           |");
Console.WriteLine("|         LPR AULA 5        |");
Console.WriteLine("|                           |");
Console.WriteLine("-----------------------------");
Console.ResetColor();



double horas_por_dia;

Console.Write("Digite o número de horas de treinamento por dia (de segunda a sexta): ");
while (!double.TryParse(Console.ReadLine(), out horas_por_dia) || horas_por_dia <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("!!!Entrada inválida! Digite um número positivo para as horas de treinamento!!!");
    Console.ResetColor();
    Console.Write("Digite o número de horas de treinamento por dia (de segunda a sexta): ");
}

double horas_por_semana = horas_por_dia * 5;

double total_de_horas = 0;
int dias = 0;

while (total_de_horas < 1000)
{
    total_de_horas += horas_por_dia;
    dias++;
}

int semanas = dias / 5; 
int meses = (int)(semanas / 4.5);


Console.WriteLine($"\nTotal de dias de treinamento: {dias} dias.");
Console.WriteLine($"Total de semanas de treinamento: {semanas} semanas.");
Console.WriteLine($"Total de meses de treinamento: {meses} meses.");