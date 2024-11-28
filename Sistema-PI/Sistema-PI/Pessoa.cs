using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PI
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string data_de_nascimento { get; set; }

        public void pegarNome()
        {
            string val;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite seu nome:");
                Nome = Console.ReadLine();

                Console.WriteLine($"\nNome: {Nome}");
                Console.WriteLine("O nome está correto?");
                Console.WriteLine("1) Sim");
                Console.WriteLine("Q) Não");
                Console.Write("Escolha uma opção: ");
                val = Console.ReadLine()?.ToUpper();
                if (val != "1" && val != "Q")
                {
                    Console.WriteLine("\nErro: Opção inválida! Tente novamente.");
                    Console.ReadKey();
                }

            } while (val == "Q");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public void pegarCpf()
        {
            string val;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite seu CPF (somente números):");
                Cpf = Console.ReadLine()?.Trim();

                while (Cpf == null || Cpf.Length != 11 || !Cpf.All(char.IsDigit))
                {
                    Console.WriteLine("CPF inválido! Digite novamente:");
                    Cpf = Console.ReadLine()?.Trim();
                }

                Cpf = $"{Cpf.Substring(0, 3)}.{Cpf.Substring(3, 3)}.{Cpf.Substring(6, 3)}-{Cpf.Substring(9, 2)}";
                Console.WriteLine($"\nCPF: {Cpf}");
                Console.WriteLine("O CPF está correto?");
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
        public void pegarTelefone()
        {
            string val;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite seu Telefone com DDD (somente números):");
                Telefone = Console.ReadLine()?.Trim();

                while (Telefone == null || Telefone.Length != 11 || !Telefone.All(char.IsDigit))
                {
                    Console.WriteLine("Telefone inválido! Digite novamente:");
                    Telefone = Console.ReadLine()?.Trim();
                }

                Telefone = $"({Telefone.Substring(0, 2)}) {Telefone.Substring(2, 5)}-{Telefone.Substring(7, 4)}";
                Console.WriteLine($"\nTelefone: {Telefone}");
                Console.WriteLine("O Telefone está correto?");
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
        public void pegarData()
        {
            DateTime dataNascimento;
            bool dataConfirmada = false;

            while (!dataConfirmada)
            {
                Console.Clear();
                Console.WriteLine("Digite sua data de nascimento (DD/MM/AAAA):");

                if (DateTime.TryParse(Console.ReadLine(), out dataNascimento) && dataNascimento <= DateTime.Now)
                {
                    Console.WriteLine($"Você digitou: {dataNascimento:dd/MM/yyyy}");
                    Console.WriteLine("A data está correta?\n1) Sim\n2) Não");
                    string opcao = Console.ReadLine();

                    if (opcao == "1")
                    {
                        Console.WriteLine($"Data confirmada: {dataNascimento:dd/MM/yyyy}");
                        dataConfirmada = true;
                    }
                    else if (opcao == "2")
                    {
                        Console.WriteLine("Vamos tentar novamente...");
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida. Tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Data inválida. Certifique-se de usar o formato correto e que a data não seja no futuro.");
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
