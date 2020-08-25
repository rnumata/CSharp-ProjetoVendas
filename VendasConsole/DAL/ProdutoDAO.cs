using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class ProdutoDAO
    {

        //Banco de Dados Produto
        private static List<Produto> produtos = new List<Produto>();



        public static List<Produto> ListarProdutos() => produtos;


        public static Produto ExisteProduto(String nome)
        {
            foreach (Produto p in produtos)
            {
                if (p.Nome.Equals(nome))
                {
                    return p;
                }
            }
            return null;
        }


        public static bool Cadastrar(Produto p)
        {
            if (ExisteProduto(p.Nome) == null)
            {
                produtos.Add(p);
                return true;
                
            } else
            {
                return false;
            }
        }



    }
}
