using System;

namespace Controle_de_Poltronas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] lugares = new int[10, 15];
            int fileira = 0;
            int poltrona = 0;
            string opcao = " ";
            string opcao2 = "";
            opcao = opcao.ToUpper();

            Console.WriteLine("BEM VINDO AO TEATRO LATINIDADES");
            Console.WriteLine("ESCOLHAS AS OPÇÕES");
            while (opcao!="N")
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("MENU DE OPÇÕES");
                Console.WriteLine("1 - ESCOLHER ASSENTOS");
                Console.WriteLine("N - SAIR");
                Console.Write("OPÇÃO DESEJADA: ");
                opcao = Console.ReadLine();
                opcao = opcao.ToUpper();
                Console.Clear();

                switch (opcao)
                {
                    case "1":
                        
                        while (opcao2!="N")
                        {
                           
                            Console.WriteLine("ESCOLHA SUA FILEIRA: ");
                            Console.WriteLine("0 - FILEIRA A: FILEIRA FRENTE AO PALCO");
                            Console.WriteLine("1 - FILEIRA B: SEGUNDA FILEIRA FRENTE DO PALCO");
                            Console.WriteLine("2 - FILEIRA C: TERCEIRA FILEIRA FRENTE DO PALCO");
                            Console.WriteLine("3 - FILEIRA D: MEIO  DO TEATRO");
                            Console.WriteLine("4 - FILEIRA E: MEIO  DO TEATRO");
                            Console.WriteLine("5 - FILEIRA F: MEIO  DO TEATRO");
                            Console.WriteLine("6 - FILEIRA G: MEIO  DO TEATRO");
                            Console.WriteLine("7 - FILEIRA H: ANTEPENÚLTIMA FILA DO TEATRO");
                            Console.WriteLine("8 - FILEIRA I: PENÚLTIMA FILA DO TEATRO");
                            Console.WriteLine("9 - FILEIRA J: ULTIMA FILA DO TEATRO");
                            Console.Write("SUA ESCOLHA: ");
                            fileira = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (opcao)
                            {
                                case "0":
                                    Console.Write("ESCOLHA A POLTRONA: ");
                                    poltrona = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    if (lugares[fileira, poltrona] == 0)
                                    {
                                        lugares[fileira, poltrona] = 1;
                                        Console.WriteLine("VOCÊ ESCOLHEU: COLUNA: " + fileira + " POLTRONA: " + poltrona);
                                        Console.WriteLine("POLTRONA RESERVADA COM SUCESSO! BOM SHOW!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("LUGAR OCUPADO ! POR FAVOR SELECIONE OUTRO ASSENTO");
                                    }
                                    Console.WriteLine("DESEJA PROSSEGUIR PARA SELEÇÃO DE FILEIRA E POLTRONA? [s]SIM / [n]NÃO");
                                    opcao2 = Console.ReadLine();
                                    opcao2 = opcao2.ToUpper();
                                    Console.Clear();
                                    break;

                                case "1":
                                    Console.Write("ESCOLHA A POLTRONA: ");
                                    poltrona = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    if (lugares[fileira, poltrona] == 0)
                                    {
                                        lugares[fileira, poltrona] = 1;
                                        Console.WriteLine("VOCÊ ESCOLHEU: COLUNA: " + fileira + " POLTRONA: " + poltrona);
                                        Console.WriteLine("POLTRONA RESERVADA COM SUCESSO! BOM SHOW!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("LUGAR OCUPADO ! POR FAVOR SELECIONE OUTRO ASSENTO");
                                    }
                                    Console.WriteLine("DESEJA PROSSEGUIR PARA SELEÇÃO DE FILEIRA E POLTRONA? [s]SIM / [n]NÃO");
                                    opcao2 = Console.ReadLine();
                                    opcao2 = opcao2.ToUpper();
                                    Console.Clear();
                                    break;

                                case "2":
                                    Console.Write("ESCOLHA A POLTRONA: ");
                                    poltrona = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    if (lugares[fileira, poltrona] == 0)
                                    {
                                        lugares[fileira, poltrona] = 1;
                                        Console.WriteLine("VOCÊ ESCOLHEU: COLUNA: " + fileira + " POLTRONA: " + poltrona);
                                        Console.WriteLine("POLTRONA RESERVADA COM SUCESSO! BOM SHOW!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("LUGAR OCUPADO ! POR FAVOR SELECIONE OUTRO ASSENTO");
                                    }
                                    Console.WriteLine("DESEJA PROSSEGUIR PARA SELEÇÃO DE FILEIRA E POLTRONA? [s]SIM / [n]NÃO");
                                    opcao2 = Console.ReadLine();
                                    opcao2 = opcao2.ToUpper();
                                    Console.Clear();
                                    break;

                                case "3":
                                    Console.Write("ESCOLHA A POLTRONA: ");
                                    poltrona = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    if (lugares[fileira, poltrona] == 0)
                                    {
                                        lugares[fileira, poltrona] = 1;
                                        Console.WriteLine("VOCÊ ESCOLHEU: COLUNA: " + fileira + " POLTRONA: " + poltrona);
                                        Console.WriteLine("POLTRONA RESERVADA COM SUCESSO! BOM SHOW!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("LUGAR OCUPADO ! POR FAVOR SELECIONE OUTRO ASSENTO");
                                    }
                                    Console.WriteLine("DESEJA PROSSEGUIR PARA SELEÇÃO DE FILEIRA E POLTRONA? [s]SIM / [n]NÃO");
                                    opcao2 = Console.ReadLine();
                                    opcao2 = opcao2.ToUpper();
                                    Console.Clear();
                                    break;

                                case "4":
                                    Console.Write("ESCOLHA A POLTRONA: ");
                                    poltrona = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    if (lugares[fileira, poltrona] == 0)
                                    {
                                        lugares[fileira, poltrona] = 1;
                                        Console.WriteLine("VOCÊ ESCOLHEU: COLUNA: " + fileira + " POLTRONA: " + poltrona);
                                        Console.WriteLine("POLTRONA RESERVADA COM SUCESSO! BOM SHOW!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("LUGAR OCUPADO ! POR FAVOR SELECIONE OUTRO ASSENTO");
                                    }
                                    Console.WriteLine("DESEJA PROSSEGUIR PARA SELEÇÃO DE FILEIRA E POLTRONA? [s]SIM / [n]NÃO");
                                    opcao2 = Console.ReadLine();
                                    opcao2 = opcao2.ToUpper();
                                    Console.Clear();
                                    break;

                                case "5":
                                    Console.Write("ESCOLHA A POLTRONA: ");
                                    poltrona = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    if (lugares[fileira, poltrona] == 0)
                                    {
                                        lugares[fileira, poltrona] = 1;
                                        Console.WriteLine("VOCÊ ESCOLHEU: COLUNA: " + fileira + " POLTRONA: " + poltrona);
                                        Console.WriteLine("POLTRONA RESERVADA COM SUCESSO! BOM SHOW!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("LUGAR OCUPADO ! POR FAVOR SELECIONE OUTRO ASSENTO");
                                    }
                                    Console.WriteLine("DESEJA PROSSEGUIR PARA SELEÇÃO DE FILEIRA E POLTRONA? [s]SIM / [n]NÃO");
                                    opcao2 = Console.ReadLine();
                                    opcao2 = opcao2.ToUpper();
                                    Console.Clear();
                                    break;

                                case "6":
                                    Console.Write("ESCOLHA A POLTRONA: ");
                                    poltrona = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    if (lugares[fileira, poltrona] == 0)
                                    {
                                        lugares[fileira, poltrona] = 1;
                                        Console.WriteLine("VOCÊ ESCOLHEU: COLUNA: " + fileira + " POLTRONA: " + poltrona);
                                        Console.WriteLine("POLTRONA RESERVADA COM SUCESSO! BOM SHOW!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("LUGAR OCUPADO ! POR FAVOR SELECIONE OUTRO ASSENTO");
                                    }
                                    Console.WriteLine("DESEJA PROSSEGUIR PARA SELEÇÃO DE FILEIRA E POLTRONA? [s]SIM / [n]NÃO");
                                    opcao2 = Console.ReadLine();
                                    opcao2 = opcao2.ToUpper();
                                    Console.Clear();
                                    break;

                                case "7":
                                    Console.Write("ESCOLHA A POLTRONA: ");
                                    poltrona = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    if (lugares[fileira, poltrona] == 0)
                                    {
                                        lugares[fileira, poltrona] = 1;
                                        Console.WriteLine("VOCÊ ESCOLHEU: COLUNA: " + fileira + " POLTRONA: " + poltrona);
                                        Console.WriteLine("POLTRONA RESERVADA COM SUCESSO! BOM SHOW!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("LUGAR OCUPADO ! POR FAVOR SELECIONE OUTRO ASSENTO");
                                    }
                                    Console.WriteLine("DESEJA PROSSEGUIR PARA SELEÇÃO DE FILEIRA E POLTRONA? [s]SIM / [n]NÃO");
                                    opcao2 = Console.ReadLine();
                                    opcao2 = opcao2.ToUpper();
                                    Console.Clear();
                                    break;

                                case "8":
                                    Console.Write("ESCOLHA A POLTRONA: ");
                                    poltrona = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    if (lugares[fileira, poltrona] == 0)
                                    {
                                        lugares[fileira, poltrona] = 1;
                                        Console.WriteLine("VOCÊ ESCOLHEU: COLUNA: " + fileira + " POLTRONA: " + poltrona);
                                        Console.WriteLine("POLTRONA RESERVADA COM SUCESSO! BOM SHOW!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("LUGAR OCUPADO ! POR FAVOR SELECIONE OUTRO ASSENTO");
                                    }
                                    Console.WriteLine("DESEJA PROSSEGUIR PARA SELEÇÃO DE FILEIRA E POLTRONA? [s]SIM / [n]NÃO");
                                    opcao2 = Console.ReadLine();
                                    opcao2 = opcao2.ToUpper();
                                    Console.Clear();
                                    break;

                                case "9":
                                    Console.Write("ESCOLHA A POLTRONA: ");
                                    poltrona = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    if (lugares[fileira, poltrona] == 0)
                                    {
                                        lugares[fileira, poltrona] = 1;
                                        Console.WriteLine("VOCÊ ESCOLHEU: COLUNA: " + fileira + " POLTRONA: " + poltrona);
                                        Console.WriteLine("POLTRONA RESERVADA COM SUCESSO! BOM SHOW!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("LUGAR OCUPADO ! POR FAVOR SELECIONE OUTRO ASSENTO");
                                    }
                                    Console.WriteLine("DESEJA PROSSEGUIR PARA SELEÇÃO DE FILEIRA E POLTRONA? [s]SIM / [n]NÃO");
                                    opcao2 = Console.ReadLine();
                                    opcao2 = opcao2.ToUpper();
                                    Console.Clear();
                                    break;                               

                                default:
                                    Console.WriteLine("ERRO! FAVOR ESCOLHER CORRETAMENTE A FILEIRA E POLTRONA!");
                                    Console.WriteLine("DESEJA PROSSEGUIR PARA SELEÇÃO DE FILEIRA E POLTRONA? [s]SIM / [n]NÃO");
                                    opcao2 = Console.ReadLine();
                                    opcao2 = opcao2.ToUpper();
                                    Console.Clear();
                                    break;

                            }
                        }
                        break;
                    case "N":
                        break;
                }
            }
            Console.WriteLine("OBRIGADO PELA PREFERÊNCIA!");
        }
    }
}
