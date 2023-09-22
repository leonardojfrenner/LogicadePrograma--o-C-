using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace matriz

{

class Program

{

static bool[] poltronas = new bool[46];

static void Main()

{ // incio

int opcao;

do

{

Console.WriteLine("----- MENU -----");

Console.WriteLine("1 - Inserir Poltrona (OCUPADA)");

Console.WriteLine("2 - Alterar Poltrona (LIVRE)");

Console.WriteLine("3 - Listar Poltronas (TODAS)");

Console.WriteLine("4 - Buscar Poltronas (ESPECÍFICA)");

Console.WriteLine("5 - Liberar Poltronas (TODAS)");

Console.WriteLine("6 - Sair");

Console.WriteLine("-----------------");

Console.Write("Digite a opção desejada: ");

opcao = int.Parse(Console.ReadLine());

switch (opcao)

{

case 1:

InserirPoltrona();

break;

case 2:

AlterarPoltrona();

break;

case 3:

ListarPoltronas();

break;

case 4:

BuscarPoltronas();

break;

case 5:

LiberarPoltronas();

break;

case 6:

Console.WriteLine("Saindo do programa...");

break;

default:

Console.WriteLine("Opção inválida. Tente novamente.");

break;

}

Console.WriteLine();

} while (opcao != 6);

}

static void InserirPoltrona()

{

Console.Write("Digite o número da poltrona a ser marcada como OCUPADA: ");

int numeroPoltrona = int.Parse(Console.ReadLine());

if (ValidarPoltrona(numeroPoltrona))

{

if (poltronas[numeroPoltrona - 1])

{

Console.WriteLine("Poltrona já está OCUPADA.");

}

else

{

poltronas[numeroPoltrona - 1] = true;

Console.WriteLine("Poltrona marcada como OCUPADA com sucesso.");

}

}

else

{

Console.WriteLine("Número de poltrona inválido.");

}

}

static void AlterarPoltrona()

{

Console.Write("Digite o número da poltrona a ser marcada como LIVRE: ");

int numeroPoltrona = int.Parse(Console.ReadLine());

if (ValidarPoltrona(numeroPoltrona))

{

if (poltronas[numeroPoltrona - 1])

{

poltronas[numeroPoltrona - 1] = false;

Console.WriteLine("Poltrona marcada como LIVRE com sucesso.");

}

else

{

Console.WriteLine("Poltrona já está LIVRE.");

}

}

else

{

Console.WriteLine("Número de poltrona inválido.");

}

}

static void ListarPoltronas()

{

Console.WriteLine("----- Poltronas Ocupadas -----");

for (int i = 0; i < poltronas.Length; i++)

{

if (poltronas[i])

{

Console.WriteLine("Poltrona " + (i + 1));

}

}

Console.WriteLine("------------------------------");

}

static void BuscarPoltronas()

{

Console.Write("Digite o número da poltrona a ser buscada: ");

int numeroPoltrona = int.Parse(Console.ReadLine());

if (ValidarPoltrona(numeroPoltrona))

{

if (poltronas[numeroPoltrona - 1])

{

Console.WriteLine("Poltrona " + numeroPoltrona + " está OCUPADA.");

}

else

{

Console.WriteLine("Poltrona " + numeroPoltrona + " está LIVRE.");

}

}

else

{

Console.WriteLine("Número de poltrona inválido.");

}

}

static void LiberarPoltronas()

{

for (int i = 0; i < poltronas.Length; i++)

{

poltronas[i] = false;

}

Console.WriteLine("Todas as poltronas foram liberadas.");

}

static bool ValidarPoltrona(int numeroPoltrona)

{

return numeroPoltrona >= 1 && numeroPoltrona <= poltronas.Length;

Console.ReadKey();

}

} //fim