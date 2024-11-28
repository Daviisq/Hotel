using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PI
{
    internal class FormaPagamento
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public bool PagamentoConfirmado { get; set; }

        public FormaPagamento(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
            DataPagamento = DateTime.Now;
            PagamentoConfirmado = false;
        }
        public void ConfirmarPagamento()
        {
            PagamentoConfirmado = true;
            Console.WriteLine($"Pagamento de R${Valor} via {Nome} confirmado com sucesso!");
        }
        public void ExibirInformacoesPagamento()
        {
            Console.WriteLine($"Forma de Pagamento: {Nome}");
            Console.WriteLine($"Valor: R${Valor}");
            Console.WriteLine($"Data do Pagamento: {DataPagamento}");
            Console.WriteLine($"Pagamento Confirmado: {PagamentoConfirmado}");
            Console.WriteLine();
        }
    }

    internal class FormasDePagamento
    {
        public List<FormaPagamento> Pagamentos { get; set; }

        public FormasDePagamento()
        {
            Pagamentos = new List<FormaPagamento>();
        }
        public void AdicionarPagamento(FormaPagamento pagamento)
        {

            Pagamentos.Add(pagamento);
            Console.WriteLine($"Forma de pagamento {pagamento.Nome} adicionada com sucesso.");
        }

        public void ExibirPagamentos()
        {
            Console.Clear();
            Console.WriteLine("=== Listagem de Formas de Pagamento ===");
            if (Pagamentos.Count > 0)
            {
                foreach (var pagamento in Pagamentos)
                {
                    pagamento.ExibirInformacoesPagamento();
                }
            }
            else
            {
                Console.WriteLine("Nenhuma forma de pagamento registrada.");
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void RealizarPagamento(string nomePagamento, decimal valor)
        {
            var pagamento = Pagamentos.Find(p => p.Nome == nomePagamento);
            if (pagamento != null)
            {
                if (valor == pagamento.Valor)
                {
                    pagamento.ConfirmarPagamento();
                }
                else
                {
                    Console.WriteLine("Valor do pagamento não corresponde ao valor da transação.");
                }
            }
            else
            {
                Console.WriteLine("Forma de pagamento não encontrada.");
            }
        }
        public bool VerificarPagamentoConfirmado(string nomePagamento)
        {
            var pagamento = Pagamentos.Find(p => p.Nome == nomePagamento);
            if (pagamento != null)
            {
                return pagamento.PagamentoConfirmado;
            }
            else
            {
                Console.WriteLine("Forma de pagamento não encontrada.");
                return false;
            }
        }
        public void FiltrarPagamentosPorTipo(string tipo)
        {
            Console.Clear();
            Console.WriteLine($"=== Pagamentos via {tipo} ===");
            var pagamentosFiltrados = Pagamentos.FindAll(p => p.Nome.Equals(tipo, StringComparison.OrdinalIgnoreCase));

            if (pagamentosFiltrados.Count > 0)
            {
                foreach (var pagamento in pagamentosFiltrados)
                {
                    pagamento.ExibirInformacoesPagamento();
                }
            }
            else
            {
                Console.WriteLine($"Nenhum pagamento encontrado para a forma {tipo}.");
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public decimal CalcularTotalPagamentos()
        {
            decimal total = 0;
            foreach (var pagamento in Pagamentos)
            {
                total += pagamento.Valor;
            }
            return total;
        }
        public decimal CalcularTotalPagamentosConfirmados()
        {
            decimal total = 0;
            foreach (var pagamento in Pagamentos)
            {
                if (pagamento.PagamentoConfirmado)
                {
                    total += pagamento.Valor;
                }
            }
            return total;
        }
        public void ExibirMaiorPagamento()
        {
            var maiorPagamento = Pagamentos.Count > 0 ? Pagamentos[0] : null;

            foreach (var pagamento in Pagamentos)
            {
                if (pagamento.Valor > maiorPagamento.Valor)
                {
                    maiorPagamento = pagamento;
                }
            }

            if (maiorPagamento != null)
            {
                Console.WriteLine("=== Maior Pagamento ===");
                maiorPagamento.ExibirInformacoesPagamento();
            }
            else
            {
                Console.WriteLine("Nenhum pagamento registrado.");
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public void ExibirPagamentosConfirmados()
        {
            Console.Clear();
            Console.WriteLine("=== Pagamentos Confirmados ===");
            var pagamentosConfirmados = Pagamentos.FindAll(p => p.PagamentoConfirmado);

            if (pagamentosConfirmados.Count > 0)
            {
                foreach (var pagamento in pagamentosConfirmados)
                {
                    pagamento.ExibirInformacoesPagamento();
                }
            }
            else
            {
                Console.WriteLine("Nenhum pagamento confirmado.");
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public decimal CalcularSaldoDevedor()
        {
            decimal totalPago = CalcularTotalPagamentosConfirmados();
            decimal totalPrevisto = CalcularTotalPagamentos();
            return totalPrevisto - totalPago;
        }
    }
}
