using System;
using System.Collections.Generic;

// Classe Reserva
public class Reserva
{
    public int Id { get; set; }
    public DateTime DataReserva { get; set; }
    public string Servico { get; set; }
    public Cliente Cliente { get; set; }

    public Reserva(int id, DateTime dataReserva, string servico, Cliente cliente)
    {
        Id = id;
        DataReserva = dataReserva;
        Servico = servico;
        Cliente = cliente;
    }
}

// Classe Cliente
public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public List<Reserva> Reservas { get; set; }

    public Cliente(int id, string nome, string email)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Reservas = new List<Reserva>();
    }

    public void AdicionarReserva(Reserva reserva)
    {
        Reservas.Add(reserva);
        reserva.Cliente = this;
    }

    public List<Reserva> ListarReservasFuturas()
    {
        List<Reserva> reservasFuturas = new List<Reserva>();
        DateTime hoje = DateTime.Now;

        foreach (Reserva reserva in Reservas)
        {
            if (reserva.DataReserva > hoje)
            {
                reservasFuturas.Add(reserva);
            }
        }
        return reservasFuturas;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Reservas ===");
        
        // Criar cliente
        Console.Write("Nome do cliente: ");
        string nome = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        
        Cliente cliente = new Cliente(1, nome, email);
        
        while (true)
        {
            Console.WriteLine("\n1 - Adicionar Reserva");
            Console.WriteLine("2 - Ver Reservas Futuras");
            Console.WriteLine("3 - Sair");
            Console.Write("Opção: ");
            
            string opcao = Console.ReadLine();
            
            if (opcao == "1")
            {
                Console.Write("Serviço: ");
                string servico = Console.ReadLine();
                Console.Write("Data (dd/mm/aaaa): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                
                Reserva reserva = new Reserva(cliente.Reservas.Count + 1, data, servico, cliente);
                cliente.AdicionarReserva(reserva);
                Console.WriteLine("Reserva adicionada!");
            }
            else if (opcao == "2")
            {
                Console.WriteLine($"\nReservas futuras de {cliente.Nome}:");
                List<Reserva> futuras = cliente.ListarReservasFuturas();
                
                if (futuras.Count == 0)
                {
                    Console.WriteLine("Nenhuma reserva futura.");
                }
                else
                {
                    foreach (Reserva reserva in futuras)
                    {
                        Console.WriteLine($"- {reserva.Servico} em {reserva.DataReserva:dd/MM/yyyy}");
                    }
                }
            }
            else if (opcao == "3")
            {
                break;
            }
        }
    }
}