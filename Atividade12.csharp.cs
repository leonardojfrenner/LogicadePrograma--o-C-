static void Main(string[] args)

{ // 3 - Elaborar um programa que permita que o usuário escreva seu nome completo. Mostrar na tela:

// Nome e o sobrenome separadamente.

// O conteúdo da string do caractere cinco ao dez.

// Substituir todos os caracteres ‘a’ pelo ‘o’.

string nome, sobrenome, nome_completo, nome_ret, nome_invert;

Console.WriteLine("Digite seu nome: ");

nome = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome: ");

sobrenome = Console.ReadLine();

Console.WriteLine("Seu primeiro noome é: " + nome);

Console.WriteLine("Seu segundo nome é: " + sobrenome);

nome_completo = nome + (" ") + sobrenome;

Console.WriteLine("Seu nome completo é: " + nome_completo);

nome_ret = nome_completo.Substring(5, 10);

Console.WriteLine("O conteúdo retornado: " + nome_ret);

nome_invert = nome_completo.Replace("a", "o");

Console.WriteLine("com letras invertidas: " + nome_invert);

//4 – Crie um gerador de e-mail que solicite o nome do usuário completo

//e mostre ao final o email: nome@fatec.sp.gov.br

string email;

email = nome.ToLower() + "@fatec.sp.gov.br";

Console.WriteLine("Seu email é: " + email);

// 5 – DESAFIO(Crie um gerador de e-mail que solicite o nome do usuário completo

// e mostre ao final o email: nome.ultimosobrenome@fatec.sp.gov.br

string gerar_email;

gerar_email=nome.ToLower()+(".")+sobrenome.ToLower()+"@fatec.sp.gov.br";

Console.WriteLine("Gera email automático: " + gerar_email);

Console.ReadKey();
}