﻿using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class CadastrarCarrinho
    {
                                
        public static List<Carrinho> InserirItens()
        {
            List<Carrinho> ItensCarrinho = new List<Carrinho>();

            Carrinho cc = new Carrinho();
            Produto p = new Produto();
            

            do
            {
                Console.WriteLine("Informe o produto: ");
                p.Nome = Console.ReadLine();
                if (ProdutoDAO.ExisteProduto(p.Nome) != null)
                {
                    cc.Produto = ProdutoDAO.ExisteProduto(p.Nome);

                    Console.WriteLine("Informe a qtde: ");
                    cc.Quantidade = Convert.ToInt32(Console.ReadLine());

                    if(cc.Quantidade > cc.Produto.Saldo)
                    {
                        Console.WriteLine("Sem saldo em estoque");
                    } 
                    else
                    {
                        ItensCarrinho.Add(cc);
                        ProdutoDAO.AtualizarSaldo(p.Nome, cc.Quantidade);
                        cc = new Carrinho();
                    }
                                   
                }
                else
                {
                    Console.WriteLine("Produto NAO cadastrado!");
                }

                Console.WriteLine("\nDeseja Continuar comprando? S/N");
                

            } while (Console.ReadLine().ToUpper().Equals("S"));


            Console.WriteLine("Deseja Cadastrar a compra? S/N");
            
            if (Console.ReadLine().ToUpper().Equals("S"))
            {
                return ItensCarrinho;
            }

            return null;
                       
        }

    }
}
