using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace matriz

{

class Program

{

static void Main(string[] args)

{//inico

Console.Write("Quantidade de alunos: ");

int qtdAlunos = Convert.ToInt32(Console.ReadLine());

Console.Write("Quantidade de avaliações: ");

int qtdAvaliacoes = Convert.ToInt32(Console.ReadLine());

double[,] notas = new double[qtdAlunos, qtdAvaliacoes];

for (int i = 0; i < qtdAlunos; i++)

{

Console.WriteLine($"Entre com as notas do aluno {i + 1}");

for (int j = 0; j < qtdAvaliacoes; j++)

{

Console.Write($"Nota {j + 1}: ");

notas[i, j] = Convert.ToDouble(Console.ReadLine());

}

}

for (int i = 0; i < qtdAlunos; i++)

{

double soma = 0;

for (int j = 0; j < qtdAvaliacoes; j++)

{

soma += notas[i, j];

}

double media = soma / qtdAvaliacoes;

Console.WriteLine($"Media do aluno {i + 1}: {media}");

}

Console.ReadLine();

}//fim

}