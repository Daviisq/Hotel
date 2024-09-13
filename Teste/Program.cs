using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 100;
            Gerente[] gerente = new Gerente[max];
            Funcionario[] funcionario = new Funcionario[max];
            Cliente[] cliente = new Cliente[max];
            bool sair = false, cadastrado;
            int[] opc = new int[max];
            do
            {
                do
                {
                    Console.WriteLine("Qual login deseja acessar?\n1)Cliente\n2)Funcionario\n3)Gerente\n4)Diretor\n5)Sair");
                    opc[0] = int.Parse(Console.ReadLine());
                    switch (opc[0])
                    {
                        case 1:
                            cadastrado = false;
                            for (int i = 0; i < max; i++)
                            {
                                if (cliente[i] != null)
                                {
                                    cadastrado = true;
                                }
                            }
                            if (cadastrado == false)
                            {
                                Console.WriteLine("Ninguem cadastrado");
                                do
                                {
                                    Console.WriteLine("Deseja cadastrar?\n1)Sim\n2)Não");
                                    opc[1] = int.Parse(Console.ReadLine());
                                    switch (opc[1])
                                    {
                                        case 1:
                                            cliente[0] = new Cliente();
                                            cliente[0].cadastrar();
                                            cliente[0].idCli = 1;
                                            cadastrado = true;
                                            break;
                                        case 2:
                                            opc[1] = 2;
                                            break;
                                        default:
                                            opc[1] = 0;
                                            break;
                                    }
                                } while (opc[1] != 1 && opc[1] != 2);
                            }
                            if (cadastrado == true)
                            {
                                for (int i = 0; i < max; i++)
                                {
                                    if (cliente[i] != null)
                                    {
                                        cliente[i].mostrar();
                                    }
                                }
                                do
                                {
                                    Console.WriteLine("Qual usuario deseja acessar(digite o id)");
                                    int id = int.Parse(Console.ReadLine());
                                    id = id - 1;
                                    Console.WriteLine($"ID: {cliente[id].idCli}\nNome: {cliente[id].nome}");
                                    Console.WriteLine("ID correto?\n1)Sim\n2)Não");
                                    opc[2] = int.Parse(Console.ReadLine());
                                    if (opc[2] == 1)
                                    {
                                        do
                                        {
                                            Console.WriteLine("Digite a senha:");
                                            string senha = Console.ReadLine();
                                            if (senha == cliente[id].senha)
                                            {
                                                Console.WriteLine($"Óla {cliente[id].nome}");
                                                opc[2] = 1;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Senha incorreta");
                                                opc[2] = 0;
                                            }
                                        } while (opc[2] == 0);
                                    }
                                    else
                                    {
                                        opc[2] = 0;
                                    }
                                } while (opc[2] == 0);
                            }

                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            Console.WriteLine("Saindo...");
                            Console.ReadKey();
                            opc[0] = 1;
                            sair = true;
                            break;
                        default:
                            break;
                    }
                } while (opc[0] == 0);
            } while (sair == false);
        }
    }
}
