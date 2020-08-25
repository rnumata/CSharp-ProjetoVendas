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
                Console.WriteLine($"Produto: {venda.Produto.Nome}\tQuantidade: {venda.Quantidade}\tVendedor: {venda.vendedor.Nome}\tCliente: {venda.cliente.Nome}");
            }

        }
    }
}
