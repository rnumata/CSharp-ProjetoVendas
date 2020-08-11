using System;

namespace VendasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int selecao;

            do
            {
                Console.Clear();
                Console.WriteLine("-- Selecione Menu --");
                Console.WriteLine("1- Cadastrar Cliente");
                Console.WriteLine("2- Listar Clientes");
                Console.WriteLine("3- Cadastrar Vendedor");
                Console.WriteLine("4- Listar Vendedores");
                Console.WriteLine("5- Cadastrar Produto");
                Console.WriteLine("6- Listar Produtos");
                Console.WriteLine("7- Registrar Venda");
                Console.WriteLine("8- Listar Vendas");
                Console.WriteLine("9- Listar Vendas por cliente");
                Console.WriteLine("0- Sair");
                Console.WriteLine("\n Digite a opção: ");
                selecao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (selecao)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção Inválida: ");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla...");
                Console.ReadKey();
            } while (selecao != 0);

           

           


















        }
    }//fim classe
}
