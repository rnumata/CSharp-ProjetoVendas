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
        private static List<Venda> vendasCliente = new List<Venda>();


        public static List<Venda> ListarVendas() => vendas;


        public static List<Venda> ListarVendasCliente(string cpf)
        {
            foreach (Venda v in vendas)
            {
                if (v.cliente.cpf.Equals(cpf))
                {
                    vendasCliente.Add(v);
                }
            }

            return vendasCliente;
        }


        public static void Cadastrar(Venda venda)
        {
            vendas.Add(venda);
        }






    }
}
