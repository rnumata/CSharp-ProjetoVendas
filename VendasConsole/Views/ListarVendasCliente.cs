using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarVendasCliente
    {

        public static void Renderizar()
        {
            string cpf;

            Console.WriteLine("----LISTAGEM VENDAS POR CLIENTE----");
            Console.WriteLine("\nInfome CPF cliente: ");
            cpf = Console.ReadLine();

            Console.WriteLine("\n----LISTAGEM DE ITENS----");
            foreach (Venda venda in VendaDAO.ListarVendas())
            {
                if (venda.cliente.cpf.Equals(cpf))
                {
                    venda.itens.ForEach((item) =>
                    {
                        Console.WriteLine($"Item: {item.Produto.Nome}\tQuantidade: {item.Quantidade}");
                    });
                }
            }

        }

    }
}
