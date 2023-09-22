//1–Desenvolva um programa para calculara área, diâmetro e perímetrodo círculo

//A =pi. r*2

//d= 2*r

//p = 2* pi * r

double area, raio,diametro,perimetro;

Console.Write("Digite or raio: ");

raio = Convert.ToDouble(Console.ReadLine());

area = Math.PI * Math.Pow(raio,2);

diametro = raio*2;

perimetro = 2 * Math.PI * raio;

Console.WriteLine("Valor da área: " + area);

Console.WriteLine("valor do diâmetro: " + diametro);

Console.WriteLine("valor do perimetro: " + perimetro);

Console.ReadKey();

