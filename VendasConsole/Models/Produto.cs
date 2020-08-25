using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.Models
{
    class Produto
    {

        public String Nome { get; set; }

        public double Preco { get; set; }

        public int Saldo { get; set; }

        public DateTime Criadoem { get; set; }



        public Produto()
        {
            Criadoem = DateTime.Now;
        }



    }
}
