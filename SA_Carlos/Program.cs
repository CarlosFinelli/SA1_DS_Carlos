using System;
using System.Collections.Generic;

namespace SA_Carlos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Reserva> listReserva = new List<Reserva>();
            List<Cliente> listClientes = new List<Cliente>();
            int opcao = 0;
            while (opcao != 6)
            {
                Console.WriteLine("Bem vindo ao sistema do nosso Restaurante");
                Console.WriteLine("1 = Cadastrar Cliente");
                Console.WriteLine("2 = Editar Cliente");
                Console.WriteLine("3 - Excluir Cliente");
                Console.WriteLine("4 = Nova Reserva");
                Console.WriteLine("5 - Lista de Reservas");
                Console.WriteLine("6 - Sair do Programa");
                Console.Write("Por favor, selecione uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch(opcao)
                {
                    case 1:
                        Cliente cliente = new Cliente();
                        Console.WriteLine("Por favor, insira o nome do cliente: ");
                        
                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:

                        break;

                    default:
                        Console.WriteLine("Esta não é uma opção válida");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                Console.Clear();
                Console.WriteLine("Obrigado por utilizar nossos serviços.");
                Console.ReadKey();
            }
        }
    }
}
