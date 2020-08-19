using System;
using System.Collections.Generic;
using VendasConsole.Controller;

namespace VendasConsole.Views
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int selecao;

            //Instanciacao de Objetos
            Cliente c = new Cliente();
            Vendedor v = new Vendedor();
           

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

                        if (VerificarCpf.ValidaInput(c.cpf))
                        {
                            if (VerificarCpf.ExisteCpf(c.cpf, c.Tipo))
                            {
                                if (VerificarCpf.ValidaCpf(c.cpf))
                                {
                                    VerificarCpf.clientes.Add(c); // !! Gravar no BD 

                                    Console.WriteLine($"Cliente: {c.Nome} e CPF: {c.cpf} Cadastrado com sucesso ! ");
                                    c = new Cliente();
                                }
                                else
                                {
                                    Console.WriteLine($"CPF {c.cpf} Invalido!");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"CPF {c.cpf} já cadastrado!");
                            }
                        } else
                        {
                            Console.WriteLine($"CPF {c.cpf} Invalido!");
                        }             
                        break;
                    case 2:
                        Console.WriteLine("----LISTAGEM DE CLIENTES----");
                        VerificarCpf.listarClientes();
                        break;
                    case 3:
                        Console.WriteLine("----CADASTRAR VENDEDOR----");
                        Console.WriteLine("Digite o nome: ");
                        v.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF: ");
                        v.cpf = Console.ReadLine();

                        if (VerificarCpf.ValidaInput(v.cpf))
                        {
                            if (VerificarCpf.ExisteCpf(v.cpf, v.Tipo))
                            {
                                if (VerificarCpf.ValidaCpf(v.cpf))
                                {
                                    VerificarCpf.vendedores.Add(v); // !! Gravar no BD 

                                    Console.WriteLine($"Vendedor: {v.Nome} e CPF: {v.cpf} Cadastrado com sucesso ! ");
                                    v = new Vendedor();
                                }
                                else
                                {
                                    Console.WriteLine($"CPF {v.cpf} Invalido!");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"CPF {v.cpf} já cadastrado!");
                            }

                        } else
                        {
                            Console.WriteLine($"CPF {v.cpf} Invalido!");
                        }
                        break;
                    case 4:
                        Console.WriteLine($"----LISTAGEM DE VENDEDORES----");
                        VerificarCpf.listarVendedores();
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

                      


    }//fim classe
}
