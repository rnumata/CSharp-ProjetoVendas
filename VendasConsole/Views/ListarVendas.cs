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
            double totalItem = 0.0;
            Console.WriteLine("----LISTAGEM DE VENDAS----");
            foreach (Venda venda in VendaDAO.ListarVendas()) 
            {
                totalItem = 0.0;
                Console.WriteLine($"\nVendedor: {venda.vendedor.Nome}\nCliente: {venda.cliente.Nome}");
                Console.WriteLine("\n----LISTAGEM DE ITENS----");
                totalItem = venda.Produto.Preco * venda.Quantidade;
                Console.WriteLine($"\nProduto: {venda.Produto.Nome}\tQuantidade: {venda.Quantidade}\tPreco Unit: {venda.Produto.Preco:C2}\tTotal: {totalItem:C2}");

            }

        }
    }
}
