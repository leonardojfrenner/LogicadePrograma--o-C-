int ano_nasc,idade, ano_atual;

Console.Write("digite o ano de nascimento: ");

ano_nasc = Convert.ToInt32(Console.ReadLine());

Console.Write("digite o ano atual: ");

ano_atual = Convert.ToInt32(Console.ReadLine());

idade = ano_nasc-ano_atual;

Console.WriteLine(idade);

Console.ReadKey();