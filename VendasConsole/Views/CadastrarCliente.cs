using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Utils;
using VendasConsole.Models;
using VendasConsole.DAL;

namespace VendasConsole.Views
{
    class CadastrarCliente
    {

        public static void Renderizar()
        {
            Cliente c = new Cliente();

            Console.WriteLine("----CADASTRAR CLIENTE----");
            Console.WriteLine("Digite o nome: ");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF: ");
            c.cpf = Console.ReadLine();

            if (Validar.ValidaCpf(c.cpf))
            {
                if (ClienteDAO.Cadastrar(c))
                {
                   Console.WriteLine($"Cliente: {c.Nome}\t | CPF: {c.cpf} \tCadastrado com sucesso !");
                   c = new Cliente();
                }
                else
                {
                   Console.WriteLine($"CPF {c.cpf} já cadastrado");
                    
                }
            }
            else
            {
                Console.WriteLine($"CPF {c.cpf} Invalido!");
            }


        }





    }
}
