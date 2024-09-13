using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Pessoa
    {
        public string nome;
        public string email;
        public string cpf;
        public string telefone;
        public string cep;
        public string endereco;
        public string data_de_nascimento;

        private bool verificarBi(int ano)
        {
            return (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
        }


        private void pegarNome()
        {
            int val;
            do
            {
                Console.WriteLine("digite seu nome:");
                nome = Console.ReadLine();
                Console.WriteLine($"Nome: {nome}\nNome esta correto?\n1)Sim\n2)Não");
                val = int.Parse(Console.ReadLine());
                if (val == 1)
                {
                    val = 1;
                }
                else if (val == 2)
                {
                    val = 0;
                }
                else
                {
                    Console.WriteLine("Erro1");
                    Console.WriteLine($"Nome: {nome}\nNome esta correto?\n1)Sim\n2)Não");
                    val = int.Parse(Console.ReadLine());
                }
            } while (val == 0);
        }

        private void pegarEmail()
        {
            int val;
            do
            {
                Console.WriteLine("digite seu email:");
                email = Console.ReadLine();
                Console.WriteLine($"Email: {email}\nEmail esta correto?\n1)Sim\n2)Não");
                val = int.Parse(Console.ReadLine());
                if (val == 1)
                {
                    val = 1;
                }
                else if (val == 2)
                {
                    val = 0;
                }
                else
                {
                    Console.WriteLine("Erro1");
                    Console.WriteLine($"Email: {email}\nEmail esta correto?\n1)Sim\n2)Não");
                    val = int.Parse(Console.ReadLine());
                }
            } while (val == 0);
        }

        private void pegarData()
        {
            int dia, mes, ano, val = 0;
            do
            {
                Console.WriteLine("Digite o ano que vc nasceu?");
                ano = int.Parse(Console.ReadLine());
                while (ano > 2024)
                {
                    Console.WriteLine("Ano invalido");
                    Console.WriteLine("Digite o Ano que vc nasceu?");
                    ano = int.Parse(Console.ReadLine());
                }
                bool bi = verificarBi(ano);
                Console.WriteLine("Digite o mês que vc nasceu?");
                mes = int.Parse(Console.ReadLine());
                while (mes > 12)
                {
                    Console.WriteLine("Ano invalido");
                    Console.WriteLine("Digite o mês que vc nasceu?");
                    mes = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Digite o dia que você nasceu");
                dia = int.Parse(Console.ReadLine());
                if ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia <= 30 ||
                (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) && dia <= 31 ||
                (mes == 2 && ((bi && dia <= 29) || (!bi && dia <= 28))))
                {
                    Console.WriteLine($"Data de nascimento: {dia}/{mes}/{ano}");
                    Console.WriteLine("Data de nascimento certa?\n1)Sim\n2)Não");
                    val = int.Parse(Console.ReadLine());
                    while (val != 1 && val != 2)
                    {
                        Console.WriteLine("Opção invalida");
                        Console.WriteLine("Data de nascimento certa?\n1)Sim\n2)Não");
                        val = int.Parse(Console.ReadLine());
                    }
                    if (val == 1)
                    {
                        data_de_nascimento = $"{dia}/{mes}/{ano}";
                        val = 1;
                    }
                    else
                    {
                        val = 0;
                    }
                }
                else
                {
                    Console.WriteLine("Erro detectado recomece");
                }
            } while (val == 0);
        }

        private void pegarCpf()
        {
            int val;
            do
            {
                Console.WriteLine("Digite seu CPF:");
                cpf = Console.ReadLine();
                while (cpf.Length != 11 || !cpf.All(char.IsDigit))
                {
                    Console.WriteLine("CPF inválido!");
                    Console.WriteLine("Digite seu CPF:");
                    cpf = Console.ReadLine();
                }
                cpf = cpf.Trim();
                cpf = $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";
                Console.WriteLine($"CPF: {cpf}\nCPF esta correto?\n1)Sim\n2)Não");
                val = int.Parse(Console.ReadLine());
                if (val == 1)
                {
                    val = 1;
                }
                else if (val == 2)
                {
                    val = 0;
                }
                else
                {
                    Console.WriteLine("Erro1");
                    Console.WriteLine($"CPF: {cpf}\nCPF esta correto?\n1)Sim\n2)Não");
                    val = int.Parse(Console.ReadLine());
                }
            } while (val == 0);
        }

        private void pegarCep()
        {
            int val;
            do
            {
                Console.WriteLine("Digite seu CEP:");
                cep = Console.ReadLine();
                while (cep.Length != 8 || !cep.All(char.IsDigit))
                {
                    Console.WriteLine("CEP inválido!");
                    Console.WriteLine("Digite seu CEP:");
                    cep = Console.ReadLine();
                }
                cep = cep.Trim();
                cep = $"{cep.Substring(0, 5)}-{cep.Substring(5, 3)}";
                Console.WriteLine($"CEP: {cep}\nCEP esta correto?\n1)Sim\n2)Não");
                val = int.Parse(Console.ReadLine());
                if (val == 1)
                {
                    val = 1;
                }
                else if (val == 2)
                {
                    val = 0;
                }
                else
                {
                    Console.WriteLine("Erro!");
                    Console.WriteLine($"CEP: {cep}\nCEP esta correto?\n1)Sim\n2)Não");
                    val = int.Parse(Console.ReadLine());
                }
            } while (val == 0);
        }

        private void pegarTelefone()
        {
            int val;
            do
            {
                Console.WriteLine("Digite seu Telefone com DDD:");
                telefone = Console.ReadLine();
                while (telefone.Length != 11 || !telefone.All(char.IsDigit))
                {
                    Console.WriteLine("Telefone inválido!");
                    Console.WriteLine("Digite seu Telefone:");
                    telefone = Console.ReadLine();
                }
                telefone = telefone.Trim();
                telefone = $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 5)}-{telefone.Substring(7, 4)}";
                Console.WriteLine(telefone);
                Console.WriteLine($"Telefone: {telefone}\nTelefone esta correto?\n1)Sim\n2)Não");
                val = int.Parse(Console.ReadLine());
                if (val == 1)
                {
                    val = 1;
                }
                else if (val == 2)
                {
                    val = 0;
                }
                else
                {
                    Console.WriteLine("Erro!");
                    Console.WriteLine($"Telefone: {telefone}\nTelefone esta correto?\n1)Sim\n2)Não");
                    val = int.Parse(Console.ReadLine());
                }
            } while (val == 0);
        }

        private void pegarEndereco()
        {
            int val;
            do
            {
                Console.WriteLine("digite seu endereco:");
                endereco = Console.ReadLine();
                Console.WriteLine($"Endereco: {endereco}\nEndereco esta correto?\n1)Sim\n2)Não");
                val = int.Parse(Console.ReadLine());
                if (val == 1)
                {
                    val = 1;
                }
                else if (val == 2)
                {
                    val = 0;
                }
                else
                {
                    Console.WriteLine("Erro!");
                    Console.WriteLine($"Endereco: {endereco}\nEndereco esta correto?\n1)Sim\n2)Não");
                    val = int.Parse(Console.ReadLine());
                }
            } while (val == 0);
        }

        protected internal virtual void cadastrar()
        {
            Console.WriteLine("Cadastro\n");
            pegarNome();
            pegarEmail();
            pegarData();
            pegarCpf();
            pegarTelefone();
            pegarCep();
            pegarEndereco();
        }

        protected internal virtual void mostrar()
        {
            Console.WriteLine($"Ola {nome}\nEmail: {email}\nData de nascimento: {data_de_nascimento}\nCPF: {cpf}\nTelefone: {telefone}\nCEP: {cep}\nEndereco: {endereco}");
        }
    }
}
