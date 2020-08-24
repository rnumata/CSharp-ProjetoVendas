using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarCliente
    {

        public static void Renderizar()
        {
           Console.WriteLine("----LISTAGEM DE CLIENTES----");
           foreach (Cliente clienteCadastrado in ClienteDAO.listarClientes())
           {
              Console.WriteLine($"Nome: {clienteCadastrado.Nome}\t| CPF: {clienteCadastrado.cpf}\t| Criado em: {clienteCadastrado.Criadoem}");
           }

        }


    }
}
