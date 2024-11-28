using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PI
{
    internal class Estoque
    {
        public string Nome { get; set; }
        public List<Produto> Produtos { get; set; }

        public Estoque(string nome)
        {
            Nome = nome;
            Produtos = new List<Produto>();
        }
        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
            Console.WriteLine($"Produto {produto.Nome} adicionado com sucesso ao estoque!");
        }
        public void ExibirProdutos()
        {
            Console.Clear();
            Console.WriteLine("=== Produtos no Estoque ===");
            if (Produtos.Count > 0)
            {
                foreach (var produto in Produtos)
                {
                    Console.WriteLine($"Produto: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: R${produto.Preco}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum produto encontrado no estoque.");
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public bool VerificarDisponibilidade(string nomeProduto, int quantidade)
        {
            var produto = Produtos.FirstOrDefault(p => p.Nome == nomeProduto);
            if (produto == null)
            {
                Console.WriteLine("Produto não encontrado.");
                return false;
            }
            else if (produto.Quantidade >= quantidade)
            {
                Console.WriteLine($"Produto {nomeProduto} disponível em quantidade suficiente.");
                return true;
            }
            else
            {
                Console.WriteLine($"Estoque insuficiente para o produto {nomeProduto}. Quantidade disponível: {produto.Quantidade}");
                return false;
            }
        }
        public void RealizarVenda(string nomeProduto, int quantidade)
        {
            var produto = Produtos.FirstOrDefault(p => p.Nome == nomeProduto);
            if (produto != null && produto.Quantidade >= quantidade)
            {
                produto.Quantidade -= quantidade;
                Console.WriteLine($"Venda realizada: {quantidade} unidades do produto {produto.Nome}.");
            }
            else
            {
                Console.WriteLine($"Não é possível realizar a venda. Produto ou quantidade insuficiente.");
            }
        }
        public void ReporEstoque(string nomeProduto, int quantidade)
        {
            var produto = Produtos.FirstOrDefault(p => p.Nome == nomeProduto);
            if (produto != null)
            {
                produto.Quantidade += quantidade;
                Console.WriteLine($"Estoque reposto: {quantidade} unidades do produto {produto.Nome}.");
            }
            else
            {
                Console.WriteLine("Produto não encontrado no estoque.");
            }
        }
        public void ExibirTotalEstoque()
        {
            var totalProdutos = Produtos.Sum(p => p.Quantidade);
            Console.WriteLine($"Total de produtos no estoque: {totalProdutos} unidades.");
            Console.ReadKey();
        }
    }
    public class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, int quantidade, decimal preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }
    }
}
