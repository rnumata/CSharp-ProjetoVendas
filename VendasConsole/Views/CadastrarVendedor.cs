using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;
using VendasConsole.Utils;

namespace VendasConsole.Views
{
    class CadastrarVendedor
    {


        public static void Renderizar()
        {
            Vendedor v = new Vendedor();

            Console.WriteLine("----CADASTRAR VENDEDOR----");
            Console.WriteLine("Digite o nome: ");
            v.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF: ");
            v.cpf = Console.ReadLine();

            if (Validar.ValidaCpf(v.cpf))
            {
                if (VendedorDAO.Cadastrar(v))
                {
                    Console.WriteLine($"Vendedor: {v.Nome}\t | CPF: {v.cpf} Cadastrado com sucesso ! ");
                    v = new Vendedor();
                }
                else
                {
                    Console.WriteLine($"CPF {v.cpf} já Cadastrado!");
                }
            }
            else
            {
                Console.WriteLine($"CPF {v.cpf} Invalido!");
            }

        }

    }
}
