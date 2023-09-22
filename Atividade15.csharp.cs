Exercício 3 03.04.2023

{
            {
            inicio:
                int op;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(3, 3);
                Console.WriteLine("╔══════════════════════════════════════════════════════════╗");
                Console.SetCursorPosition(3, 4);
                Console.WriteLine("║                                                          ║");
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("║                                                          ║");
                Console.SetCursorPosition(3, 6);
                Console.WriteLine("║                                                          ║");
                Console.SetCursorPosition(3, 7);
                Console.WriteLine("║                                                          ║");
                Console.SetCursorPosition(3, 8);
                Console.WriteLine("║                                                          ║");
                Console.SetCursorPosition(3, 9);
                Console.WriteLine("║                                                          ║");
                Console.SetCursorPosition(3, 10);
                Console.WriteLine("║                                                          ║");
                Console.SetCursorPosition(3, 11);
                Console.WriteLine("║                                                          ║");
                Console.SetCursorPosition(3, 12);
                Console.WriteLine("║                                                          ║");
                Console.SetCursorPosition(3, 13);
                Console.WriteLine("║                                                          ║");
                Console.SetCursorPosition(3, 14);
                Console.WriteLine("║                                                          ║");
                Console.SetCursorPosition(3, 15);
                Console.WriteLine("║                                                          ║");
                Console.SetCursorPosition(3, 16);
                Console.WriteLine("║                                                          ║");
                Console.SetCursorPosition(3, 17);
                Console.WriteLine("║                                                          ║");
                Console.SetCursorPosition(3, 18);
                Console.WriteLine("║                                                          ║");
                Console.SetCursorPosition(3, 19);
                Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(5, 5);
                Console.WriteLine(" Codigo");
                Console.SetCursorPosition(5, 7);
                Console.WriteLine("1");
                Console.SetCursorPosition(5, 8);
                Console.WriteLine("2");
                Console.SetCursorPosition(5, 9);
                Console.WriteLine("3");
                Console.SetCursorPosition(5, 10);
                Console.WriteLine("4");
                Console.SetCursorPosition(15, 5);
                Console.WriteLine(" Cargo");
                Console.SetCursorPosition(15, 7);
                Console.WriteLine(" Gerente");
                Console.SetCursorPosition(15, 8);
                Console.WriteLine(" Analista");
                Console.SetCursorPosition(15, 9);
                Console.WriteLine(" Tecnico");
                Console.SetCursorPosition(15, 10);
                Console.WriteLine(" Outros");
                Console.SetCursorPosition(25, 5);
                Console.WriteLine(" Aumento");
                Console.SetCursorPosition(25, 7);
                Console.WriteLine(" 10%");
                Console.SetCursorPosition(25, 8);
                Console.WriteLine(" 20% ");
                Console.SetCursorPosition(25, 9);
                Console.WriteLine(" 30%");
                Console.SetCursorPosition(25, 10);
                Console.WriteLine(" 40%");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(5, 11);
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.SetCursorPosition(5, 11);
                        Console.Write("Gerente");
                        Console.SetCursorPosition(5, 12);
                        double ger_soldo_anterior, ger_soldo_atual, dif;
                        Console.SetCursorPosition(5, 13);
                        Console.Write("Digite o salário : R$  ");
                        Console.SetCursorPosition(5, 14);
                        ger_soldo_anterior = Convert.ToDouble(Console.ReadLine());
                        ger_soldo_atual = ger_soldo_anterior * 1.10;
                        Console.SetCursorPosition(5, 15);
                        Console.WriteLine("O salário era R$ " + ger_soldo_anterior);
                        Console.SetCursorPosition(5, 16);
                        Console.WriteLine("o salário passa a ser R$ " + ger_soldo_atual);
                        dif = ger_soldo_atual - ger_soldo_anterior;
                        Console.SetCursorPosition(5, 17);
                        Console.WriteLine("a diferença salarial é R$ " + dif);
                        break;
                    case 2:
                        Console.SetCursorPosition(5, 11);
                        Console.Write("Analista");
                        Console.SetCursorPosition(5, 12);
                        double ana_soldo_anterior, ana_soldo_atual, dife;
                        Console.SetCursorPosition(5, 13);
                        Console.Write("Digite o salário : R$  ");
                        Console.SetCursorPosition(5, 14);
                        ana_soldo_anterior = Convert.ToDouble(Console.ReadLine());
                        ana_soldo_atual = ana_soldo_anterior * 1.20;
                        Console.SetCursorPosition(5, 15);
                        Console.WriteLine("O salário era R$ " + ana_soldo_anterior);
                        Console.SetCursorPosition(5, 16);
                        Console.WriteLine("o salário passa a ser R$ " + ana_soldo_atual);
                        dife = ana_soldo_atual - ana_soldo_anterior;
                        Console.SetCursorPosition(5, 17);
                        Console.WriteLine("a diferença salarial é R$ " + dife);

                        break;
                    case 3:
                        Console.SetCursorPosition(5, 11);
                        Console.Write("Tecnico");
                        Console.SetCursorPosition(5, 12);
                        double tec_soldo_anterior, tec_soldo_atual, difer;
                        Console.SetCursorPosition(5, 13);
                        Console.Write("Digite o salário : R$  ");
                        Console.SetCursorPosition(5, 14);
                        tec_soldo_anterior = Convert.ToDouble(Console.ReadLine());
                        tec_soldo_atual = tec_soldo_anterior * 1.30;
                        Console.SetCursorPosition(5, 15);
                        Console.WriteLine("O salário era R$ " + tec_soldo_anterior);
                        Console.SetCursorPosition(5, 16);
                        Console.WriteLine("o salário passa a ser R$ " + tec_soldo_atual);
                        difer = tec_soldo_atual - tec_soldo_anterior;
                        Console.SetCursorPosition(5, 17);
                        Console.WriteLine("a diferença salarial é R$ " + difer);
                        break;
                    case 4:
                        Console.SetCursorPosition(5, 11);
                        Console.Write("Demais Cargos");
                        Console.SetCursorPosition(5, 12);
                        double out_soldo_anterior, out_soldo_atual, difera;
                        Console.SetCursorPosition(5, 13);
                        Console.Write("Digite o salário : R$  ");
                        Console.SetCursorPosition(5, 14);
                        out_soldo_anterior = Convert.ToDouble(Console.ReadLine());
                        out_soldo_atual = out_soldo_anterior * 1.40;
                        Console.SetCursorPosition(5, 15);
                        Console.WriteLine("O salário era R$ " + out_soldo_anterior);
                        Console.SetCursorPosition(5, 16);
                        Console.WriteLine("o salário passa a ser R$ " + out_soldo_atual);
                        difera = out_soldo_atual - out_soldo_anterior;
                        Console.SetCursorPosition(5, 17);
                        Console.WriteLine("a diferença salarial é R$ " + difera);
                        break;
                    default:
                        Console.SetCursorPosition(5, 11);
                        Console.Clear();
                        Console.WriteLine("Nenhuma das opçoes.");
                        goto inicio;
                }
                Console.ReadKey();
            }
        }
    }