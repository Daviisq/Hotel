using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PI
{
    internal class Funcionario : Cliente
    {
        public CargoFuncionario Cargo { get; set; }
        public decimal Salario { get; set; }
        private List<Quarto> quartos = new List<Quarto>();
        public override void Cadastrar()
        {
            base.Cadastrar();
            SelecionarCargo();
        }

        private void SelecionarCargo()
        {
            Console.Clear();
            Console.WriteLine("Selecione o cargo do funcionário:");
            foreach (var cargo in Enum.GetValues(typeof(CargoFuncionario)))
            {
                Console.WriteLine($"{(int)cargo}) {cargo}");
            }

            int escolha;
            do
            {
                Console.Write("Escolha o número correspondente ao cargo: ");
                bool isValid = int.TryParse(Console.ReadLine(), out escolha);
                if (!isValid || escolha < 0 || escolha >= Enum.GetValues(typeof(CargoFuncionario)).Length)
                {
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                }
            } while (escolha < 0 || escolha >= Enum.GetValues(typeof(CargoFuncionario)).Length);

            Cargo = (CargoFuncionario)escolha;
            Console.WriteLine($"Cargo selecionado: {Cargo}");
        }
        public void ExibirFuncionario()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário: {Salario}");
        }
        public void GerenciarFuncionario(List<Quarto> quartos)
        {
            string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine($"Bem-vindo, {Nome} - Cargo: {Cargo}");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1) Ver quartos ocupados");
                Console.WriteLine("2) Ver quartos livres");
                Console.WriteLine("q) Sair");

                opcao = Console.ReadLine().ToUpper();

                switch (opcao)
                {
                    case "1":
                        VerQuartosOcupados(quartos);
                        break;
                    case "2":
                        VerQuartosLivres(quartos);
                        break;
                    case "Q":
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != "Q");
            Console.ReadKey();
        }

        private void VerQuartosOcupados(List<Quarto> quartos)
        {
            Console.WriteLine("Quartos Ocupados:");
            foreach (var quarto in quartos.Where(q => q.EstaOcupado))
            {
                Console.WriteLine($"Quarto {quarto.Numero} - Tipo: {quarto.Tipo} - Ocupado por: {quarto.ClienteOuFuncionario} - Preço: R${quarto.PrecoPorNoite} por noite");
            }
            Console.ReadKey();
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
    }
    public enum CargoFuncionario
    {
        Concierge,
        Faxineira,
        Recepcionista,
        Cozinheiro,
        Gerente
    }
}
