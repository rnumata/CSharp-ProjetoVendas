using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class CadastrarVenda
    {

        public static void Renderizar()
        {

            Venda venda = new Venda();
            Cliente c = new Cliente();
            Vendedor v = new Vendedor();
            Produto p = new Produto();

            Console.WriteLine("----CADASTRAR VENDA----");
            Console.WriteLine("Digite o CPF do Cliente: ");
            c.cpf = Console.ReadLine();
            c = ClienteDAO.ExisteCpf(c.cpf);

            if(c != null)
            {
                venda.cliente = c;
                Console.WriteLine("Digite o CPF do Vendedor: ");
                v.cpf = Console.ReadLine();
                v = VendedorDAO.ExisteCpf(v.cpf);

                if(v != null)
                {
                    venda.vendedor = v;
                    Console.WriteLine("Digite o Produto: ");
                    p.Nome = Console.ReadLine();
                    p = ProdutoDAO.ExisteProduto(p.Nome);
                    
                    if(p != null)
                    {
                        venda.Produto = p;
                        Console.WriteLine("Digite a quantidade: ");
                        venda.Quantidade = Convert.ToInt32(Console.ReadLine());

                        VendaDAO.Cadastrar(venda);
                        Console.WriteLine("Venda realizada com sucesso!");
                        venda = new Venda();
                    } else
                    {
                        Console.WriteLine("Produto NAO cadastrado!");
                    }

                } else
                {
                    Console.WriteLine("Vendedor NAO cadastrado!");
                }   
                
            } else
            {
                Console.WriteLine("Cliente NAO cadastrado!");
            }


        }


    }
}
