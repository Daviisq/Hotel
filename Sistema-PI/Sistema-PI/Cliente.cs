using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PI
{
    internal class Cliente : Pessoa
    {
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Senha { get; set; }

        private List<Quarto> quartos = new List<Quarto>();
        private List<Reserva> reservas = new List<Reserva>();

        private void pegarEmail()
        {
            string val;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite seu email:");
                Email = Console.ReadLine()?.Trim();

                Console.WriteLine($"\nEmail: {Email}");
                Console.WriteLine("O email está correto?");
                Console.WriteLine("1) Sim");
                Console.WriteLine("Q) Não");
                Console.Write("Escolha uma opção: ");

                val = Console.ReadLine()?.ToUpper();

                while (val != "1" && val != "Q")
                {
                    Console.WriteLine("Opção inválida! Digite 1 para Sim ou Q para Não:");
                    val = Console.ReadLine()?.ToUpper();
                }

            } while (val == "Q");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        private void pegarCep()
        {
            string val;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite seu CEP (somente números):");
                Cep = Console.ReadLine()?.Trim();

                while (Cep == null || Cep.Length != 8 || !Cep.All(char.IsDigit))
                {
                    Console.WriteLine("CEP inválido! Digite novamente:");
                    Cep = Console.ReadLine()?.Trim();
                }

                Cep = $"{Cep.Substring(0, 5)}-{Cep.Substring(5, 3)}";
                Console.WriteLine($"\nCEP: {Cep}");
                Console.WriteLine("O CEP está correto?");
                Console.WriteLine("1) Sim");
                Console.WriteLine("Q) Não");
                Console.Write("Escolha uma opção: ");

                val = Console.ReadLine()?.ToUpper();

                while (val != "1" && val != "Q")
                {
                    Console.WriteLine("Opção inválida! Digite 1 para Sim ou Q para Não:");
                    val = Console.ReadLine()?.ToUpper();
                }

            } while (val == "Q");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public void CadastrarSenha()
        {
            string senha, confirmacao;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite sua senha:");
                senha = Console.ReadLine();

                Console.WriteLine("Confirme sua senha:");
                confirmacao = Console.ReadLine();

                if (senha == confirmacao)
                {
                    Senha = senha;
                    Console.WriteLine("Senha cadastrada com sucesso!");
                    break;
                }
                else
                {
                    Console.WriteLine("As senhas não coincidem. Tente novamente.");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (true);
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public virtual void Cadastrar()
        {
            Console.WriteLine("Cadastro\n");
            pegarNome();
            pegarCpf();
            pegarCep();
            pegarTelefone();
            pegarEmail();
            CadastrarSenha();
        }
        public string MenuCliente()
        {
            string copc;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Menu Cliente ===");
                Console.WriteLine("1) Cadastrar");
                Console.WriteLine("2) Ver Cadastro");
                Console.WriteLine("3) Reservar quarto");
                Console.WriteLine("Q) Voltar");
                Console.Write("Escolha uma opção válida: ");
                copc = Console.ReadLine()?.ToUpper();

                if (copc != "1" && copc != "2" && copc != "3" && copc != "Q")
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }

            } while (copc != "1" && copc != "2" && copc != "3" && copc != "Q");
            return copc;
        }
        public void GerenciarCliente()
        {
            string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Gerenciamento do Cliente ===");
                Console.WriteLine("1) Ver Cadastro");
                Console.WriteLine("2) Atualizar Cadastro");
                Console.WriteLine("3) Reservar quarto");
                Console.WriteLine("4) Ver Reservas");
                Console.WriteLine("q) Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine()?.ToUpper();

                switch (opcao)
                {
                    case "1":
                        VerCadastro();
                        break;
                    case "2":
                        Cadastrar();
                        break;
                    case "3":
                        ReservarQuarto(quartos);
                        break;
                    case "4":
                        VerReservas();
                        break;
                    case "Q":
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != "Q");
        }
        public void VerCadastro()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                Console.WriteLine("Cadastro não efetuado. Deseja cadastrar?");
                Console.WriteLine("1) Sim");
                Console.WriteLine("Q) Não");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine()?.ToUpper();

                if (opcao == "1")
                {
                    Cadastrar();
                }
                else if (opcao == "Q")
                {
                    Console.WriteLine("Cadastro não realizado.");
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }
            else
            {
                string atuali;
                do
                {
                    Console.Clear();
                    Console.WriteLine("== Cadastro Atual ==");
                    Console.WriteLine($"Nome: {Nome}");
                    Console.WriteLine($"CPF: {Cpf}");
                    Console.WriteLine($"Data de Nascimento: {data_de_nascimento}");
                    Console.WriteLine($"Email: {Email}");
                    Console.WriteLine($"Telefone: {Telefone}");
                    Console.WriteLine($"CEP: {Cep}");
                    Console.WriteLine("Deseja atualizar o cadastro?");
                    Console.WriteLine("1) Sim");
                    Console.WriteLine("Q) Não");
                    Console.Write("Escolha uma opção: ");

                    atuali = Console.ReadLine()?.ToUpper();

                    if (atuali == "1")
                    {
                        Cadastrar();
                    }
                    else if (atuali == "Q")
                    {
                        Console.WriteLine("Cadastro não atualizado.");
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida. Tente novamente.");
                    }
                } while (atuali != "Q");
            }
        }
        private void VerQuartosLivres(List<Quarto> quartos)
        {
            Console.WriteLine("Quartos Livres:");
            foreach (var quarto in quartos.Where(q => !q.EstaOcupado))
            {
                Console.WriteLine($"Quarto {quarto.Numero} - Tipo: {quarto.Tipo} - Preço: R${quarto.PrecoPorNoite} por noite");
            }
            Console.ReadKey();
        }
        private void ReservarQuarto(List<Quarto> quartos)
        {
            VerQuartosLivres(quartos);

            Console.WriteLine("Digite o número do quarto que deseja reservar:");
            if (int.TryParse(Console.ReadLine(), out int numeroQuarto))
            {
                var quartoSelecionado = quartos.FirstOrDefault(q => q.Numero == numeroQuarto && !q.EstaOcupado);

                if (quartoSelecionado != null)
                {
                    quartoSelecionado.EstaOcupado = true;
                    quartoSelecionado.ClienteOuFuncionario = this.Nome;
                    Reserva novaReserva = new Reserva(this, quartoSelecionado, DateTime.Now);
                    reservas.Add(novaReserva);

                    Console.WriteLine($"Reserva realizada com sucesso para o quarto {quartoSelecionado.Numero}!");
                }
                else
                {
                    Console.WriteLine("Quarto não disponível ou número inválido.");
                }
            }
            else
            {
                Console.WriteLine("Número de quarto inválido.");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void VerReservas()
        {
            if (reservas.Count > 0)
            {
                Console.WriteLine("Suas Reservas:");
                foreach (var reserva in reservas)
                {
                    Console.WriteLine(reserva.ToString());
                }
            }
            else
            {
                Console.WriteLine("Você não tem reservas.");
            }
            Console.ReadKey();
        }
    }
}
