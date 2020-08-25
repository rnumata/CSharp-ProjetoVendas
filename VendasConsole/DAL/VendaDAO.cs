using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class VendaDAO
    {

        // Banco de dados de Vendas
        private static List<Venda> vendas = new List<Venda>();

        public static List<Venda> ListarVendas() => vendas;

        public static void Cadastrar(Venda venda)
        {
            vendas.Add(venda);
        }






    }
}
