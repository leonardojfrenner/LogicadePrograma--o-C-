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
            Console.SetCursorPosition(6, 5);
            Console.WriteLine("1 - Bhaskara");
            Console.SetCursorPosition(6, 6);
            Console.WriteLine("2 - Força");
            Console.SetCursorPosition(6, 7);
            Console.WriteLine("3 - Velocidade");
            Console.SetCursorPosition(6, 8);
            Console.WriteLine("4 - SAIR ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(25, 5);
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.SetCursorPosition(25, 5);
                    Console.WriteLine("Bhaskara");
                    Console.SetCursorPosition(25, 6);
                    double a, b, c, delta, x1, x2;
                    Console.WriteLine("Digite o valor de A ");
                    Console.SetCursorPosition(25, 7);
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 8);
                    Console.WriteLine("Digite o valor de B ");
                    Console.SetCursorPosition(25, 9);
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 10);
                    Console.WriteLine("Digite o valor de C ");
                    Console.SetCursorPosition(25, 11);
                    c = Convert.ToDouble(Console.ReadLine());
                    delta = Math.Pow(b, 2) - 4 * a * c;
                    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    Console.SetCursorPosition(25, 12);
                    Console.WriteLine("O valor de delta é: " + delta);
                    Console.SetCursorPosition(25, 13);
                    Console.WriteLine("o valor de x1 é: " + x1);
                    Console.SetCursorPosition(25, 14);
                    Console.WriteLine("o valor de x2 é: " + x2);
                    break;
                case 2:
                    Console.SetCursorPosition(25, 5);
                    Console.WriteLine("Força");
                    double forc,massa,ace;
                    Console.SetCursorPosition(25, 6);
                    Console.WriteLine("Entre com valor de massa: ");
                    Console.SetCursorPosition(25, 7);
                    massa = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 8);
                    Console.WriteLine("entre com a aceleração: ");
                    Console.SetCursorPosition(25, 9);
                    ace = Convert.ToDouble(Console.ReadLine());
                    forc = massa * ace;
                    Console.SetCursorPosition(25, 10);
                    Console.WriteLine("a força resultante é : " + forc);
                    break;
                case 3:

                    Console.SetCursorPosition(25, 5);
                    Console.WriteLine("Velocidade");
                    double velo, veloci, acela, temp;
                    Console.SetCursorPosition(25, 6);
                    Console.WriteLine("Entre com a velocidade inicial: ");
                    Console.SetCursorPosition(25, 7);
                    veloci = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 8);
                    Console.WriteLine("e qual aceleração ? ");
                    Console.SetCursorPosition(25, 9);
                    acela = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 10);
                    Console.WriteLine("Por quanto tempo ? ");
                    Console.SetCursorPosition(25, 11);
                    temp = Convert.ToDouble(Console.ReadLine());
                    velo= (veloci + acela) * temp;
                    Console.SetCursorPosition(25, 12);
                    Console.WriteLine("A velocidade é : " + velo );
                    break;
                case 4:
                    Console.SetCursorPosition(25, 5);
                    Console.WriteLine("SAIR");
                    break;
                default:
                    Console.SetCursorPosition(25, 5);
                    Console.Clear();
                    Console.WriteLine("Nenhuma das opçoes.");
                    goto inicio;
            }
            Console.ReadKey();
        }
    


