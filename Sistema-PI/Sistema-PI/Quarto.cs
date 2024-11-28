using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PI
{
    internal class Quarto
    {
        public int Numero { get; set; }
        public TipoQuarto Tipo { get; set; }
        public bool EstaOcupado { get; set; }
        public decimal PrecoPorNoite { get; set; }
        public string ClienteOuFuncionario { get; set; }

        public Quarto(int numero, TipoQuarto tipo, decimal precoPorNoite)
        {
            Numero = numero;
            Tipo = tipo;
            EstaOcupado = false;
            PrecoPorNoite = precoPorNoite;
            ClienteOuFuncionario = string.Empty;
        }

        public void AlterarDisponibilidade(bool disponibilidade, string nomeCliente)
        {
            EstaOcupado = disponibilidade;
            ClienteOuFuncionario = nomeCliente;
        }
    }
    public enum TipoQuarto
    {
        Standard,
        Luxo,
        Suite,
        Presidencial
    }
}
