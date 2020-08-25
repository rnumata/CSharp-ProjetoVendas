using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class VendedorDAO
    {

        // Banco de Dados Vendedor
        public static List<Vendedor> vendedores = new List<Vendedor>();


        /// <summary>
        /// Metodo utiliza arrow function
        /// </summary>
        /// <returns></returns>
        public static List<Vendedor> listarVendedores() => vendedores;



        /// <summary>
        /// Metodo que recebe um cpf e verifica se existe em uma lista
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns> true se existe e true se nao existe </returns>
        public static Vendedor ExisteCpf(String cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            foreach (Vendedor v in vendedores)
            {
                if (cpf.Equals(v.cpf))
                {
                    return v;
                }
            }
            return null;
        }


        /// <summary>
        ///  Metodo que recebe um objeto Vendedor para cadastrar
        /// </summary>
        /// <param name="c"></param>
        /// <returns> Se cadastro ok add na List e retorne true </returns>
        public static bool Cadastrar(Vendedor v)
        {
            if (ExisteCpf(v.cpf) == null)
            {
                vendedores.Add(v);
                return true;
            } 
            else
            {
                return false;
            }
                        
        }



    }
}
