using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class CadastrarProduto
    {

        public static void Renderizar()
        {

            Produto p = new Produto();

            Console.WriteLine("----CADASTRAR CLIENTE----");
            Console.WriteLine("Digite o Produto: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preço: ");
            p.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a qtde: ");
            p.Saldo = Convert.ToInt32(Console.ReadLine());

            if (ProdutoDAO.Cadastrar(p))
            {
                Console.WriteLine($"Produto {p.Nome} cadastrado !!");
                p = new Produto();
            } else
            {
                Console.WriteLine("Produto já cadastrado!");
            }


        }



    }
}
