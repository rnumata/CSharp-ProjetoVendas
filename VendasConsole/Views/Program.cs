using System;
using System.Collections.Generic;

namespace VendasConsole.Views
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int selecao;

            //Objeto de clientes
            Cliente c = new Cliente(); 

            //Lista de Objetos
            List<Cliente> clientes = new List<Cliente>();

            do
            {
                Console.Clear();
                Console.WriteLine("-- Selecione Menu --");
                Console.WriteLine("1- Cadastrar Cliente");
                Console.WriteLine("2- Listar Clientes");
                Console.WriteLine("3- Cadastrar Vendedor");
                Console.WriteLine("4- Listar Vendedores");
                Console.WriteLine("5- Cadastrar Produto");
                Console.WriteLine("6- Listar Produtos");
                Console.WriteLine("7- Registrar Venda");
                Console.WriteLine("8- Listar Vendas");
                Console.WriteLine("9- Listar Vendas por cliente");
                Console.WriteLine("0- Sair");
                Console.WriteLine("\n Digite a opção: ");
                selecao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (selecao)
                {
                    case 1:
                        Console.WriteLine("----CADASTRAR CLIENTE----");
                        Console.WriteLine("Digite o nome: ");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF: ");
                        c.cpf = Console.ReadLine();
                                                
                        if(ExisteCpf(clientes, c.cpf))
                        {
                            if (ValidaCpf(c.cpf))
                            {
                                clientes.Add(c);
                                Console.WriteLine($"Cliente: {c.Nome} e CPF: {c.cpf} ");
                                c = new Cliente();
                            } else
                            {
                                Console.WriteLine($"CPF {c.cpf} Invalido!");
                            }                                                        
                        } else
                        {
                            Console.WriteLine($"CPF {c.cpf} já cadastrado!");
                        }                     
                        break;
                    case 2:
                        Console.WriteLine("----LISTAGEM DE CLIENTES----");
                        foreach (Cliente item in clientes)
                        {
                            Console.WriteLine($"Nome: {item.Nome} - CPF: {item.cpf} - Criado em: {item.Criadoem}");
                        }
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção Inválida: ");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla...");
                Console.ReadKey();
            } while (selecao != 0);

           

           


        }//fim main


        /**
         * Metodo recebe um List de clientes e verifica se o cpf informado já existe na lista
         * Return 1 caso true e 0 caso false
         */
        public static bool ExisteCpf(List<Cliente> clientes, String cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");
            foreach (Cliente item in clientes)
            {
                if (cpf.Equals(item.cpf))
                {
                    return false;
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
            if(resto1 < 2)
            {
                resto1 = 0;
            } else
            {
                resto1 = 11 - resto1;
            }
                        
            int convert1 = (int)Char.GetNumericValue(cpf[9]);
            //se 1o digito ( resto1 ) eh valido entra no if para validar 2o digito
            if(resto1 == convert1)
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
                if(resto2 < 2)
                {
                    resto2 = 0;
                } else
                {
                    resto2 = 11 - resto2;                   
                }

                int convert2 = (int)Char.GetNumericValue(cpf[10]);
                if(resto2 == convert2)
                {
                    return true;
                } else
                {
                    return false;
                }

            } else
            {
                return false;
            }                 
        }//fim metodo











    }//fim classe
}
