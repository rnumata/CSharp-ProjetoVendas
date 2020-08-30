using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarVendas
    {

        public static void Renderizar()
        {
            Console.WriteLine("----LISTAGEM DE VENDAS----");
            foreach (Venda venda in VendaDAO.ListarVendas()) 
            {
                Console.WriteLine($"\nVendedor: {venda.vendedor.Nome}\nCliente: {venda.cliente.Nome}");

                Console.WriteLine("\n----LISTAGEM DE ITENS----");
                double subTotal;
                double total = 0.0;
                venda.itens.ForEach((item) => {
                    subTotal = item.Quantidade * item.Produto.Preco;
                    total += subTotal;
                    Console.WriteLine($"\nItem: {item.Produto.Nome}\tQtde: {item.Quantidade}\tPreco/un: {item.Produto.Preco:C2}\tTotal Item: {subTotal:C2}");
                });
                Console.WriteLine($"\n\t\t\t\t\t\t\tTotal Venda: {total:C2}");

            }

        }
    }
}
