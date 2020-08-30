using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.Models
{
    class Venda
    {

        public Cliente cliente { get; set; }
        public Vendedor vendedor { get; set; }

        //public Produto Produto { get; set; }
        //public int Quantidade { get; set; }

        public List<Carrinho> itens = new List<Carrinho>();

        public DateTime Criadoem { get; set; }

        public Venda()
        {
            Criadoem = DateTime.Now;

        }



    }
}
