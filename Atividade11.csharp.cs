// 2 – Elabore um programa que calcule a equação de segundo grau utilizando a formulade Bhaskara. OBS:O usuário deve entrar com ‘a’,‘b’ e ‘c’ e devemos calcular o valor de‘x1’e‘x2’.

//delta é b*b -4 *a*C

// x = -b=-raiz de delta sobre 2*a

double a, b, c,delta,x1,x2;

Console.WriteLine("Digite o valor de A ");

a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor de B ");

b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor de C ");

c = Convert.ToDouble(Console.ReadLine());

delta = Math.Pow(b, 2) - 4 * a * c;

x1 = (-b + Math.Sqrt(delta))/2*a;

x2 = (-b - Math.Sqrt(delta)) / 2 * a;

Console.WriteLine("O valor de delta é: " + delta);

Console.WriteLine("o valor de x1 é: " + x1);

Console.WriteLine("o valor de x2 é: " + x2);

Console.ReadKey();

