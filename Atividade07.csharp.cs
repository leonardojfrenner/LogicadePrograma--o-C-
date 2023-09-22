int ano, mes, dias;

Console.Write("digite o ano: ");

ano = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o mes: ");

mes = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o dia: ");

dias = Convert.ToInt32(Console.ReadLine());

dias = (ano * 365) + (mes * 30) + dias;

Console.Write(dias);

Console.ReadKey();