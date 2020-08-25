using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class ClienteDAO
    {

        // Banco de Dados Cliente
        private static List<Cliente> clientes = new List<Cliente>();


        /// <summary>
        /// Metodo usa arrow function   
        /// </summary>
        /// <returns> List de clientes </returns>
        public static List<Cliente> listarClientes() => clientes;
       

       
        /// <summary>
        /// Metodo que recebe um cpf e verifica se existe em uma lista
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns> true se existe e true se nao existe </returns>
        public static Cliente ExisteCpf(String cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            foreach (Cliente c in clientes)
            {
               if (c.cpf == cpf)
               {
                 return c;
               }
            }
               return null;

        }


        /// <summary>
        ///  Metodo que recebe um objeto Cliente para cadastrar
        /// </summary>
        /// <param name="c"></param>
        /// <returns> Se cadastro ok add na List e retorne true </returns>
        public static bool Cadastrar(Cliente c)
        {
            if (ExisteCpf(c.cpf) == null)
            {
                clientes.Add(c);
                return true;
                
            } else
            {
                return false;
            }
        }




    }
}
