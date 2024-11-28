using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PI
{
    internal class Hotel
    {
        public string Nome { get; set; }
        public List<Quarto> Quartos { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Reserva> Reservas { get; set; }

        public Hotel(string nome)
        {
            Nome = nome;
            Quartos = new List<Quarto>();
            Funcionarios = new List<Funcionario>();
            Clientes = new List<Cliente>();
            Reservas = new List<Reserva>();
        }
        public void AdicionarQuarto(Quarto quarto)
        {
            Quartos.Add(quarto);
            Console.WriteLine($"Quarto {quarto.Numero} adicionado com sucesso!");
        }

        public void ExibirQuartosDisponiveis()
        {
            Console.Clear();
            Console.WriteLine("=== Quartos Disponíveis ===");
            bool encontrouDisponivel = false;
            foreach (var quarto in Quartos.Where(q => !q.EstaOcupado))
            {
                Console.WriteLine($"Quarto {quarto.Numero} - Tipo: {quarto.Tipo} - Preço: R${quarto.PrecoPorNoite} por noite");
                encontrouDisponivel = true;
            }

            if (!encontrouDisponivel)
            {
                Console.WriteLine("Nenhum quarto disponível no momento.");
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void RealizarCheckIn(Cliente cliente, Quarto quarto)
        {
            if (quarto.EstaOcupado)
            {
                Console.WriteLine("Este quarto já está ocupado.");
            }
            else
            {
                quarto.EstaOcupado = true;
                quarto.ClienteOuFuncionario = cliente.Nome;
                Reserva novaReserva = new Reserva(cliente, quarto, DateTime.Now);
                Reservas.Add(novaReserva);
                Console.WriteLine($"Check-in realizado com sucesso para o quarto {quarto.Numero}!");
            }
        }
        public void RealizarCheckOut(Cliente cliente, Quarto quarto)
        {
            if (!quarto.EstaOcupado || quarto.ClienteOuFuncionario != cliente.Nome)
            {
                Console.WriteLine("Este quarto não está ocupado por este cliente.");
            }
            else
            {
                quarto.EstaOcupado = false;
                quarto.ClienteOuFuncionario = null;
                Console.WriteLine($"Check-out realizado com sucesso para o quarto {quarto.Numero}!");
            }
        }
        public void ExibirReservas()
        {
            if (Reservas.Count > 0)
            {
                Console.WriteLine("Reservas Atuais:");
                foreach (var reserva in Reservas)
                {
                    Console.WriteLine(reserva.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nenhuma reserva realizada até o momento.");
            }
            Console.ReadKey();
        }
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
            Console.WriteLine($"Funcionário {funcionario.Nome} adicionado com sucesso!");
        }
        public void AdicionarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
            Console.WriteLine($"Cliente {cliente.Nome} adicionado com sucesso!");
        }
        public void ExibirFuncionarios()
        {
            if (Funcionarios.Count > 0)
            {
                Console.WriteLine("Lista de Funcionários:");
                foreach (var funcionario in Funcionarios)
                {
                    Console.WriteLine(funcionario.Nome);
                }
            }
            else
            {
                Console.WriteLine("Nenhum funcionário cadastrado.");
            }
            Console.ReadKey();
        }
        public void ExibirClientes()
        {
            if (Clientes.Count > 0)
            {
                Console.WriteLine("Lista de Clientes:");
                foreach (var cliente in Clientes)
                {
                    Console.WriteLine(cliente.Nome);
                }
            }
            else
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
            }
            Console.ReadKey();
        }
        public void ExibirTodasReservas()
        {
            if (Reservas.Count > 0)
            {
                Console.WriteLine("=== Todas as Reservas ===");
                foreach (var reserva in Reservas)
                {
                    Console.WriteLine(reserva.ToString());
                }
            }
            else
            {
                Console.WriteLine("Não há reservas registradas.");
            }
            Console.ReadKey();
        }
    }
}
