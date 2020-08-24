using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarVendedor
    {

        public static void Renderizar()
        {
            Console.WriteLine("----LISTAGEM DE VENDEDORES----");
            foreach (Vendedor vendedor in VendedorDAO.listarVendedores())
            {
                Console.WriteLine($"Nome: {vendedor.Nome}\t| CPF: {vendedor.cpf}\t | Criado em: {vendedor.Criadoem}");
            }

        }

    }
}
