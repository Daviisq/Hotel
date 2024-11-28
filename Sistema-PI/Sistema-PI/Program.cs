using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Funcionario> funcionarios = new List<Funcionario>();
            List<Quarto> quartos = new List<Quarto>();

            quartos.Add(new Quarto(101, TipoQuarto.Standard, 150.00m));
            quartos.Add(new Quarto(102, TipoQuarto.Luxo, 250.00m));
            quartos.Add(new Quarto(103, TipoQuarto.Suite, 350.00m));
            quartos.Add(new Quarto(104, TipoQuarto.Presidencial, 500.00m));

            clientes.Add(new Cliente());
            funcionarios.Add(new Funcionario());

            string opc = "";
            do
            {
                Console.Clear();
                Console.WriteLine("== Bem Vindo ao Hotel Skyline! ==");
                Console.WriteLine("Qual opcao deseja acessar?\n1)Cliente\n2)Funcionario\nq)Sair");
                Console.Write("Escolha uma opção válida: \n");
                opc = Console.ReadLine().ToUpper();
                switch (opc)
                {
                    case "1":
                        if (clientes.Count == 0)
                        {
                            Console.WriteLine("Nenhum cliente registrado. Vamos cadastrar um novo cliente.");
                            CadastrarCliente(clientes);
                        }

                        string email, senha;
                        Cliente clienteLogado;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("=== Login de Cliente ===");
                            Console.Write("Digite seu email: ");
                            email = Console.ReadLine();
                            Console.Write("Digite sua senha: ");
                            senha = Console.ReadLine();
                            clienteLogado = VerificarLogin(clientes, email, senha);

                            if (clienteLogado != null)
                            {
                                Console.WriteLine("Login bem-sucedido!");
                                clienteLogado.GerenciarCliente();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Email ou senha incorretos. Deseja tentar novamente ou criar uma nova conta?");
                                Console.WriteLine("1) Tentar novamente");
                                Console.WriteLine("2) Criar nova conta");
                                Console.Write("Escolha uma opção: ");
                                string opcao = Console.ReadLine()?.ToUpper();

                                if (opcao == "1")
                                {
                                    Console.WriteLine("Tentando novamente...");
                                }
                                else if (opcao == "2")
                                {
                                    CadastrarCliente(clientes);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Opção inválida. Retornando ao menu...");
                                    break;
                                }
                            }

                        } while (clienteLogado == null);

                        break;
                    case "2":
                        if (funcionarios.Count == 0)
                        {
                            Console.WriteLine("Nenhum funcionário registrado. Vamos cadastrar um novo funcionário.");
                            CadastrarFuncionario(funcionarios);
                        }

                        Funcionario funcionarioLogado;
                        string femail, fsenha;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("=== Login de Funcionário ===");
                            Console.Write("Digite seu email: ");
                            femail = Console.ReadLine();
                            Console.Write("Digite sua senha: ");
                            fsenha = Console.ReadLine();
                            funcionarioLogado = VerificarLoginFuncionario(funcionarios, femail, fsenha);

                            if (funcionarioLogado != null)
                            {
                                Console.WriteLine("Login bem-sucedido!");
                                funcionarioLogado.GerenciarFuncionario(quartos);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Email ou senha incorretos. Deseja tentar novamente ou criar um novo cadastro?");
                                Console.WriteLine("1) Tentar novamente");
                                Console.WriteLine("2) Criar novo cadastro");
                                Console.Write("Escolha uma opção: ");
                                string opcao = Console.ReadLine()?.ToUpper();

                                if (opcao == "1")
                                {
                                    Console.WriteLine("Tentando novamente...");
                                }
                                else if (opcao == "2")
                                {
                                    CadastrarFuncionario(funcionarios);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Opção inválida. Retornando ao menu...");
                                    break;
                                }
                            }
                        } while (funcionarioLogado == null);
                        break;
                    case "q":
                        break;
                    default:
                        break;
                }
            } while (opc != "Q");
        }
        static Cliente VerificarLogin(List<Cliente> clientes, string email, string senha)
        {
            foreach (var cliente in clientes)
            {
                if (cliente.Email == email && cliente.Senha == senha)
                {
                    return cliente;
                }
            }
            return null;
        }
        static Funcionario VerificarLoginFuncionario(List<Funcionario> funcionarios, string email, string senha)
        {
            foreach (var funcionario in funcionarios)
            {
                if (funcionario.Email == email && funcionario.Senha == senha)
                {
                    return funcionario;
                }
            }
            return null;
        }
        static void CadastrarCliente(List<Cliente> clientes)
        {
            Cliente cliente = new Cliente();
            cliente.Cadastrar();
            clientes.Add(cliente);
        }
        static void CadastrarFuncionario(List<Funcionario> funcionarios)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Cadastrar();
            funcionarios.Add(funcionario);
        }
    }
}
