using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarProdutos
    {

        public static void Renderizar()
        {
            Console.WriteLine("----LISTAGEM DE PRODUTOS----");
            foreach (Produto p in ProdutoDAO.ListarProdutos())
            {
                Console.WriteLine($"Produto: {p.Nome}\t | Preco: {p.Preco}\t | Saldo: {p.Saldo}");
            }

        }




    }
}
