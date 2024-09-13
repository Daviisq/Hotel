using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Cliente
    {
        protected internal int idCli;
        protected internal string senha;
        protected internal string tipoCadastro;

        protected virtual void pegarsenha()
        {
            bool sair = false;
            do
            {
                Console.WriteLine("Digite sua senha:");
                senha = Console.ReadLine();
                Console.WriteLine("Confirme sua senha:");
                string confirmar = Console.ReadLine();
                if (senha == confirmar)
                {
                    Console.WriteLine("Senha definida com sucesso");
                    sair = true;
                }
                else
                {
                    Console.WriteLine("Erro ao definir senha");
                    sair = false;
                }
            } while (sair == false);
        }

        protected internal override void cadastrar()
        {
            base.cadastrar();
            pegarsenha();
        }

        protected internal override void mostrar()
        {
            Console.WriteLine($"ID: {idCli}\nNome: {nome}");
        }
    }
}
