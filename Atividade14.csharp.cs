exercicio 2 
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
            Console.WriteLine("1 - Adicao");
            Console.SetCursorPosition(6, 6);
            Console.WriteLine("2 - Subtração");
            Console.SetCursorPosition(6, 7);
            Console.WriteLine("3 - Multiplicação");
            Console.SetCursorPosition(6, 8);
            Console.WriteLine("4 - Divisão ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(25, 5);
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.SetCursorPosition(25, 5);
                    Console.WriteLine("Adição");
                    Console.SetCursorPosition(25, 6);
                    double  adicao,a, b;
                    Console.WriteLine("Digite o valor de A ");
                    Console.SetCursorPosition(25, 7);
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 8);
                    Console.WriteLine("Digite o valor de B ");
                    Console.SetCursorPosition(25, 9);
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 10);
                    adicao = a + b;
                    Console.SetCursorPosition(25, 11);
                    Console.WriteLine("o resultado da soma é: " + adicao);
                    break;
                case 2:
                    Console.SetCursorPosition(25, 5);
                    Console.WriteLine("Subtração");
                    Console.SetCursorPosition(25, 6);
                    double sub, num1, num2;
                    Console.WriteLine("Digite o valor de A ");
                    Console.SetCursorPosition(25, 7);
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 8);
                    Console.WriteLine("Digite o valor de B ");
                    Console.SetCursorPosition(25, 9);
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 10);
                    sub = num1 - num2;
                    Console.SetCursorPosition(25, 11);
                    Console.WriteLine("o resultado da Subtração  é: " + sub );
                    break;
                case 3:
                    Console.SetCursorPosition(25, 5);
                    Console.WriteLine("Multiplicação");
                    Console.SetCursorPosition(25, 6);
                    double multi, num3, num4;
                    Console.WriteLine("Digite o valor de A ");
                    Console.SetCursorPosition(25, 7);
                    num3 = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 8);
                    Console.WriteLine("Digite o valor de B ");
                    Console.SetCursorPosition(25, 9);
                    num4 = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 10);
                    multi = num3 * num4;
                    Console.SetCursorPosition(25, 11);
                    Console.WriteLine("o resultado da multiplicação é: " + multi);
                    break;
                case 4:
                    Console.SetCursorPosition(25, 5);
                    Console.WriteLine("Divisão");
                    Console.SetCursorPosition(25, 6);
                    double div, num5, num6;
                    Console.WriteLine("Digite o valor de A ");
                    Console.SetCursorPosition(25, 7);
                    num5 = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 8);
                    Console.WriteLine("Digite o valor de B ");
                    Console.SetCursorPosition(25, 9);
                    num6 = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 10);
                    div = num5 * num6;
                    Console.SetCursorPosition(25, 11);
                    Console.WriteLine("o resultado da divisão é: " + div);
                    break;
                default:
                    Console.SetCursorPosition(25, 5);
                    Console.Clear();
                    Console.WriteLine("Nenhuma das opçoes.");
                    goto inicio;
            }
            Console.ReadKey();
        }
    