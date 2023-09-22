int nota1, nota2, nota3, media;

Console.Write("digite a nota 1: ");

nota1 = Convert.ToInt32(Console.ReadLine());

Console.Write("digite a nota 2: ");

nota2 = Convert.ToInt32(Console.ReadLine());

Console.Write("digite a nota 3: ");

nota3 = Convert.ToInt32(Console.ReadLine());

media = (nota1*2)+(nota2*3)+(nota3*5)/10;

Console.WriteLine(media);

Console.ReadKey();