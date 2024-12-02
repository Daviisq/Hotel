using System;
using MySql.Data.MySqlClient;

namespace LEGAL2
{
    internal class Program
    {
        // String de conexão
        static string connectionString = "server=localhost;uid=root;pwd='';database=sky";

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("============================================");
                    Console.WriteLine("    Bem-vindo ao Sistema de Gerenciamento    ");
                    Console.WriteLine("                de Hotel                     ");
                    Console.WriteLine("============================================");
                    Console.WriteLine("1. Cadastrar Cliente");
                    Console.WriteLine("2. Ver Clientes e Senhas");
                    Console.WriteLine("3. Cadastrar Quarto");
                    Console.WriteLine("4. Ver Status dos Quartos");
                    Console.WriteLine("5. Ver Funcionários");
                    Console.WriteLine("6. Fazer Reserva");
                    Console.WriteLine("7. Ver Reservas Ativas");
                    Console.WriteLine("9. Sair");
                    Console.Write("Escolha uma opção: ");
                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            CadastrarCliente();
                            break;
                        case "2":
                            VerClientesESenhas();
                            break;
                        case "3":
                            CadastrarQuarto();
                            break;
                        case "4":
                            VerStatusQuartos();
                            break;
                        case "5":
                            VerFuncionarios();
                            break;
                        case "6":
                            FazerReserva();
                            break;
                        case "7":
                            VerReservasAtivas();
                            break;
                        case "9":
                            Console.WriteLine("Saindo...");
                            return;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }

                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        static void CadastrarCliente()
        {
            using (var conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    Console.Write("Insira o nome do cliente: ");
                    string nome = Console.ReadLine();
                    Console.Write("Insira o email do cliente: ");
                    string email = Console.ReadLine();
                    Console.Write("Insira o telefone do cliente: ");
                    string telefone = Console.ReadLine();
                    Console.Write("Insira o CPF do cliente: ");
                    string cpf = Console.ReadLine();
                    Console.Write("Insira o endereço do cliente: ");
                    string endereco = Console.ReadLine();
                    Console.Write("Insira a senha do cliente: ");
                    string senha = Console.ReadLine();

                    if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(senha))
                    {
                        Console.WriteLine("Erro: Campos obrigatórios não podem ficar vazios.");
                        return;
                    }

                    string sql = @"INSERT INTO cliente (nome_cli, email_cli, tel_cli, cpf_cli, end_cli, senha_cli)
                                   VALUES (@nome, @email, @telefone, @cpf, @endereco, @senha)";
                    using (var comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@email", email);
                        comando.Parameters.AddWithValue("@telefone", telefone);
                        comando.Parameters.AddWithValue("@cpf", cpf);
                        comando.Parameters.AddWithValue("@endereco", endereco);
                        comando.Parameters.AddWithValue("@senha", senha);
                        comando.ExecuteNonQuery();
                        Console.WriteLine("Cliente cadastrado com sucesso!");
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Erro ao acessar o banco de dados: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro inesperado: {ex.Message}");
                }
            }
        }

        static void VerClientesESenhas()
        {
            using (var conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    string sql = "SELECT id_cli, nome_cli, senha_cli FROM cliente";
                    using (var comando = new MySqlCommand(sql, conexao))
                    using (var leitor = comando.ExecuteReader())
                    {
                        Console.WriteLine("Clientes cadastrados e suas senhas:");
                        while (leitor.Read())
                        {
                            Console.WriteLine($"ID: {leitor["id_cli"]}, Nome: {leitor["nome_cli"]}, Senha: {leitor["senha_cli"]}");
                        }
                    }

                    Console.Write("\nDeseja alterar a senha de algum cliente? (s/n): ");
                    string resposta = Console.ReadLine().ToLower();
                    if (resposta == "s")
                    {
                        Console.Write("Digite o ID do cliente: ");
                        int idCliente = int.Parse(Console.ReadLine());
                        AlterarSenhaCliente(idCliente);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao buscar clientes e senhas: {ex.Message}");
                }
            }
        }

        static void AlterarSenhaCliente(int idCliente)
        {
            using (var conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    Console.Write("Digite a nova senha: ");
                    string novaSenha = Console.ReadLine();

                    string sql = @"UPDATE cliente SET senha_cli = @novaSenha WHERE id_cli = @idCliente";
                    using (var comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@novaSenha", novaSenha);
                        comando.Parameters.AddWithValue("@idCliente", idCliente);
                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                            Console.WriteLine("Senha alterada com sucesso!");
                        else
                            Console.WriteLine("Erro: Cliente não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao alterar a senha: {ex.Message}");
                }
            }
        }

        static void CadastrarQuarto()
        {
            using (var conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    Console.Write("Insira o ID do tipo de quarto: ");
                    int idTipo = int.Parse(Console.ReadLine());
                    Console.Write("Insira o status inicial do quarto (Disponível, Limpo, etc.): ");
                    string status = Console.ReadLine();

                    string sql = @"INSERT INTO quarto (id_tipo, status) VALUES (@idTipo, @status)";
                    using (var comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@idTipo", idTipo);
                        comando.Parameters.AddWithValue("@status", status);
                        comando.ExecuteNonQuery();
                        Console.WriteLine("Novo quarto cadastrado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao cadastrar quarto: {ex.Message}");
                }
            }
        }

        static void VerStatusQuartos()
        {
            using (var conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    string sql = @"SELECT q.id_quarto, tq.nome_q, q.status 
                                   FROM quarto q 
                                   JOIN tipo_quarto tq ON q.id_tipo = tq.id_tipo";
                    using (var comando = new MySqlCommand(sql, conexao))
                    using (var leitor = comando.ExecuteReader())
                    {
                        Console.WriteLine("Status dos quartos:");
                        while (leitor.Read())
                        {
                            Console.WriteLine($"ID: {leitor["id_quarto"]}, Tipo: {leitor["nome_q"]}, Status: {leitor["status"]}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao buscar status dos quartos: {ex.Message}");
                }
            }
        }

        static void VerFuncionarios()
        {
            using (var conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    string sql = "SELECT id_funcionario, nome_funcionario FROM funcionario";
                    using (var comando = new MySqlCommand(sql, conexao))
                    using (var leitor = comando.ExecuteReader())
                    {
                        Console.WriteLine("Funcionários cadastrados:");
                        while (leitor.Read())
                        {
                            Console.WriteLine($"ID: {leitor["id_funcionario"]}, Nome: {leitor["nome_funcionario"]}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao buscar funcionários: {ex.Message}");
                }
            }
        }

        static void FazerReserva()
        {
            using (var conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    Console.Write("Insira o ID do cliente: ");
                    int idCliente = int.Parse(Console.ReadLine());
                    Console.Write("Insira o ID do quarto: ");
                    int idQuarto = int.Parse(Console.ReadLine());
                    Console.Write("Insira a data de check-in (aaaa-mm-dd): ");
                    DateTime dataCheckin = DateTime.Parse(Console.ReadLine());
                    Console.Write("Insira a data de check-out (aaaa-mm-dd): ");
                    DateTime dataCheckout = DateTime.Parse(Console.ReadLine());
                    Console.Write("Insira o valor total da reserva: ");
                    decimal total = decimal.Parse(Console.ReadLine());

                    string sql = @"INSERT INTO reserva (id_cli, id_quarto, data_checkin, data_checkout, total) 
                                   VALUES (@idCliente, @idQuarto, @dataCheckin, @dataCheckout, @total)";
                    using (var comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@idCliente", idCliente);
                        comando.Parameters.AddWithValue("@idQuarto", idQuarto);
                        comando.Parameters.AddWithValue("@dataCheckin", dataCheckin);
                        comando.Parameters.AddWithValue("@dataCheckout", dataCheckout);
                        comando.Parameters.AddWithValue("@total", total);
                        comando.ExecuteNonQuery();
                        Console.WriteLine("Reserva realizada com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao realizar reserva: {ex.Message}");
                }
            }
        }

        static void VerReservasAtivas()
        {
            using (var conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    string sql = @"SELECT r.id_reserva, c.nome_cli, q.id_quarto, r.data_checkin, r.data_checkout
                                   FROM reserva r
                                   JOIN cliente c ON r.id_cli = c.id_cli
                                   JOIN quarto q ON r.id_quarto = q.id_quarto
                                   WHERE r.data_checkout > NOW()";
                    using (var comando = new MySqlCommand(sql, conexao))
                    using (var leitor = comando.ExecuteReader())
                    {
                        Console.WriteLine("Reservas ativas:");
                        while (leitor.Read())
                        {
                            Console.WriteLine($"ID Reserva: {leitor["id_reserva"]}, Cliente: {leitor["nome_cli"]}, Quarto: {leitor["id_quarto"]}, " +
                                              $"Check-in: {leitor["data_checkin"]}, Check-out: {leitor["data_checkout"]}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao buscar reservas ativas: {ex.Message}");
                }
            }
        }
    }
}
