using System;
using System.Collections.Generic;
using System.Linq;

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
                Console.Clear();
                Console.WriteLine("Bem vindo ao sistema do nosso Restaurante\n");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Editar Cliente");
                Console.WriteLine("3 - Excluir Cliente");
                Console.WriteLine("4 - Nova Reserva");
                Console.WriteLine("5 - Lista de Reservas");
                Console.WriteLine("6 - Sair do Programa\n");
                Console.Write("Por favor, selecione uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch(opcao)
                {
                    case 1:
                        Cliente cliente = new Cliente();
                        Console.Write("Por favor, insira o nome do cliente: ");
                        cliente.nome = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Por favor, insira o CPF do cliente: ");
                        cliente.CPF = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Por favor, insira o Telefone do cliente: ");
                        cliente.telefone = Console.ReadLine();
                        Console.Clear();
                        if (listClientes.Count < 1)
                        {
                            cliente.codCliente = 1;
                        } else
                        {
                            cliente.codCliente = listClientes.Last().codCliente + 1;
                        }
                        listClientes.Add(cliente);
                        continue;

                    case 2:
                        foreach(var item in listClientes)
                        {
                            Console.WriteLine($"| Código Cliente: {item.codCliente} | Nome: {item.nome} | CPF: {item.CPF} | Telefone: {item.telefone} |");
                            Console.WriteLine("--------------------------------------------------------------------------------");
                        }
                        Console.Write("\nPor favor, selecione o código do cliente que deseja editar: ");
                        int cod = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        var alteraCliente = listClientes.Find(item => item.codCliente == cod);
                        if (alteraCliente == null)
                        {
                            Console.WriteLine("Código inválido");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        int decisao = 0;
                        while (decisao != 2)
                        {
                            Console.Clear();
                            Console.WriteLine("1 - Nome");
                            Console.WriteLine("2 - CPF");
                            Console.WriteLine("3 - Telefone");
                            Console.Write("Selecione a opção que deseja alterar: ");
                            cod = Convert.ToInt32(Console.ReadLine());
                            if (cod == 1)
                            {
                                Console.Write("Insira o novo nome: ");
                                alteraCliente.nome = Console.ReadLine();
                                Console.Clear();
                                Console.Write("Deseja alterar mais alguma coisa? '1 = Sim, 2 = Não': ");
                                decisao = Convert.ToInt32(Console.ReadLine());
                                continue;
                            }

                            if (cod == 2)
                            {
                                Console.Write("Insira o novo CPF: ");
                                alteraCliente.CPF = Console.ReadLine();
                                Console.Clear();
                                Console.Write("Deseja alterar mais alguma coisa? '1 = Sim, 2 = Não': ");
                                decisao = Convert.ToInt32(Console.ReadLine());
                                continue;
                            }

                            if (cod == 3)
                            {
                                Console.Write("Insira o novo Telefone: ");
                                alteraCliente.telefone = Console.ReadLine();
                                Console.Clear();
                                Console.Write("Deseja alterar mais alguma coisa? '1 = Sim, 2 = Não': ");
                                decisao = Convert.ToInt32(Console.ReadLine());
                                continue;
                            }
                        }
                        continue;

                    case 3:
                        foreach (var item in listClientes)
                        {
                            Console.WriteLine($"| Código Cliente: {item.codCliente} | Nome: {item.nome} | CPF: {item.CPF} | Telefone: {item.telefone} |");
                            Console.WriteLine("--------------------------------------------------------------------------------");
                        }
                        Console.Write("\nPor favor, selecione o código do cliente que deseja editar: ");
                        cod = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        var removeCliente = listClientes.Find(item => item.codCliente == cod);
                        if (removeCliente == null)
                        {
                            Console.WriteLine("Código inválido");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        listClientes.Remove(removeCliente);
                        continue;

                    case 4:
                        Reserva reserva = new Reserva();
                        Console.Write("Por favor, informe o CPF do reservista: ");
                        String cpf = Console.ReadLine();
                        Console.Clear();
                        var confereCPF = listClientes.Find(item => item.CPF == cpf);
                        if (confereCPF == null)
                        {
                            Console.WriteLine("CPF inválido");
                            Console.ReadKey();
                            continue;
                        }
                        reserva.CPFReservista = cpf;
                        Console.Clear();
                        Console.Write("Insira o número de pessoas que farão parte dessa reserva: ");
                        reserva.nPessoas = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (reserva.nPessoas > 8)
                        {
                            Console.WriteLine("A reserva não pode ser para mais de 8 pessoas.");
                            Console.ReadKey();
                            continue;
                        }
                        Console.Write("Por favor, insira o número da mesa que deseja reservar (1 a 6): ");
                        int mesa = Convert.ToInt16(Console.ReadLine());
                        reserva.mesa.Add(mesa);
                        if (reserva.nPessoas > 4 && reserva.nPessoas <= 8)
                        {
                            Console.Clear();
                            Console.Write($"Reserva para mais de 4 pessoas, por favor, selecione mais uma mesa (Mesa já selecionada: {reserva.mesa.First()}): ");
                            mesa = Convert.ToInt16(Console.ReadLine());
                            reserva.mesa.Add(mesa);
                        }
                        Console.Clear();
                        Console.Write("Insira a data e hora da reserva (Formato esperado: AAAA-MM-DD HH:mm:ss): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        if (date.DayOfYear < DateTime.Now.DayOfYear + 3)
                        {
                            Console.Clear();
                            Console.WriteLine("A data da reserva não pode ser menor que 3 dias a partir de hoje.");
                            Console.ReadKey();
                            continue;
                        }
                        reserva.dataReserva = date;
                        if (listReserva.Count < 1)
                        {
                            reserva.idReserva = 1;
                        } else
                        {
                            reserva.idReserva = listReserva.Last().idReserva + 1;
                        }
                        listReserva.Add(reserva);
                        continue;

                    case 5:
                        foreach(var item in listReserva)
                        {
                            var cli = listClientes.Find(i => i.CPF == item.CPFReservista);
                            Console.Write($"| Nome do reservista: {cli.nome} ");
                            Console.Write($"| CPF Reservista: {item.CPFReservista} | Data e hora da Reserva: {item.dataReserva.ToString("dd-MM-yyyy HH:mm-ss")} | Número de pessoas: {item.nPessoas}|\n| Mesa(s) reservada(s): ");
                            foreach(var i in item.mesa)
                            {
                                Console.Write($"{i} ");
                            }
                            Console.WriteLine("|\n------------------------------------------------------------------------------------------------------------------------");
                        }
                        Console.ReadKey();
                        continue;

                    case 6:
                        break;

                    default:
                            Console.WriteLine("Esta não é uma opção válida");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                }
                Console.Clear();
                Console.WriteLine("Obrigado por utilizar nossos serviços.");
                Console.ReadKey();
            }
        }
    }
}
