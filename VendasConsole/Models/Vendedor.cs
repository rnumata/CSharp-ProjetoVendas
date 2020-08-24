using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.Models
{
    class Vendedor
    {

        public String Nome { get; set; }

        public String cpf { get; set; }

        public DateTime Criadoem { get; set; }

        public String Tipo { get; set; }


        public Vendedor()
        {
            Criadoem = DateTime.Now;
            Tipo = "vendedor";
        }

    }//fim classe
}
