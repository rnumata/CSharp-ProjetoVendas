using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.Controller
{
    class VerificarCpf
    {

        // Banco de Dados Cliente
        public static List<Cliente> clientes = new List<Cliente>();

        public static void listarClientes()
        {
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"Nome: {cliente.Nome} - CPF: {cliente.cpf} - Criado em: {cliente.Criadoem}");
            }
        }


        // Banco de Dados Vendedor
        public static List<Vendedor> vendedores = new List<Vendedor>();

        public static void listarVendedores()
        {
            foreach (Vendedor vendedor in vendedores)
            {
                Console.WriteLine($"Nome: {vendedor.Nome} - CPF: {vendedor.cpf} - Criado em: {vendedor.Criadoem}");
            }
        }



        /**
         * Metodo que verifica se o input do usuario eh valido
         */
        public static bool ValidaInput(String cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");
            if(cpf.Length < 11 ||
               cpf.Equals("11111111111") ||
               cpf.Equals("22222222222") ||
               cpf.Equals("33333333333") ||
               cpf.Equals("44444444444") ||
               cpf.Equals("55555555555") ||
               cpf.Equals("66666666666") ||
               cpf.Equals("77777777777") ||
               cpf.Equals("88888888888") ||
               cpf.Equals("99999999999") ||
               cpf.Equals("00000000000"))
            {
                return false;
            }
            return true;
        }


         /**
         * Metodo verifica se o cpf informado já existe na lista
         * Return 1 caso true e 0 caso false
         */
        public static bool ExisteCpf(String cpf, String tipo)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (tipo.Equals("cliente"))
            {
                foreach (Cliente item in clientes)
                {
                    if (cpf.Equals(item.cpf))
                    {
                        return false;
                    }
                }
                return true;

            } else
            {
                foreach (Vendedor item in vendedores)
                {
                    if (cpf.Equals(item.cpf))
                    {
                        return false;
                    }
                }
            }         
            return true;
        }


        /**
         * Metodo que recebe um cpf e valida se eh valido
         * 1o valida se o primeiro digito eh valido
         * se sim, valida o 2o digito
         * Return true (2 digitos validos) ou false (se um dos digitos for invalido)
         */
        public static Boolean ValidaCpf(String cpf)
        {

            int soma = 0;
            int count1 = 10;
            for (int i = 0; i < cpf.Length - 2; i++)
            {
                int val = (int)Char.GetNumericValue(cpf[i]);
                soma += (val * count1);
                count1--;
            }

            int resto1 = soma % 11;
            if (resto1 < 2)
            {
                resto1 = 0;
            }
            else
            {
                resto1 = 11 - resto1;
            }

            int convert1 = (int)Char.GetNumericValue(cpf[9]);
            //se 1o digito ( resto1 ) eh valido entra no if para validar 2o digito
            if (resto1 == convert1)
            {
                soma = 0;
                int count2 = 11;
                for (int i = 0; i < cpf.Length - 1; i++)
                {
                    int val2 = (int)Char.GetNumericValue(cpf[i]);
                    soma += (val2 * count2);
                    count2--;
                }

                int resto2 = soma % 11;
                if (resto2 < 2)
                {
                    resto2 = 0;
                }
                else
                {
                    resto2 = 11 - resto2;
                }

                int convert2 = (int)Char.GetNumericValue(cpf[10]);
                if (resto2 == convert2)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }//fim metodo





    }
}
