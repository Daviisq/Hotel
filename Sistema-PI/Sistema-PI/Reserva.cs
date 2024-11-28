using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PI
{
    internal class Reserva
    {
        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }
        public Quarto QuartoReservado { get; set; }
        public DateTime DataReserva { get; set; }

        public Reserva(Funcionario funcionario, Quarto quarto, DateTime dataReserva)
        {
            Funcionario = funcionario;
            QuartoReservado = quarto;
            DataReserva = dataReserva;
        }
        public Reserva(Cliente cliente, Quarto quarto, DateTime dataReserva)
        {
            Cliente = cliente;
            QuartoReservado = quarto;
            DataReserva = dataReserva;
        }
        public override string ToString()
        {
            return $"Reserva: Quarto {QuartoReservado.Numero} - Tipo: {QuartoReservado.Tipo} - Data: {DataReserva.ToShortDateString()}";
        }
    }
}
