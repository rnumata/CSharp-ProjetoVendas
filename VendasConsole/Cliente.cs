using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole
{
    class Cliente
    {
        //Propriedades (para criar com atalho ´prop TabTab´ )
        public string Nome { get; set;}

        public string cpf { get; set; }

        public DateTime Criadoem { get; set; }

        public String Tipo { get; set; }


        //construtor (para criar com atalho ctor tabtab)
        public Cliente()
        {
            Criadoem = DateTime.Now;
            Tipo = "cliente";
        }


    }//fim classe

}
