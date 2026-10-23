float nota1;
float nota2;
float nota3;
float nota4;
float nota5;
float resultado;

Console.Write("Bem vindo à calculadora de media. \nSerao calculados os valores de cinco numeros. \nPara prosseguir, insira o primeiro valor: ");
nota1 = float.Parse(Console.ReadLine());
Console.Write("O segundo: ");
nota2 = float.Parse(Console.ReadLine());
Console.Write("O terceiro: ");
nota3 = float.Parse(Console.ReadLine());
Console.Write("O quarto: ");
nota4 = float.Parse(Console.ReadLine());
Console.Write("O quinto: ");
nota5 = float.Parse(Console.ReadLine());
resultado = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
Console.WriteLine($"O resultado da média entre {nota1},{nota2},{nota3},{nota4},{nota5} é {resultado}.");


//Gera dizima periodica
double n1, n2, n3, media;

Console.WriteLine("Insira o valor1: ");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor2: ");
n2 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor3: ");
n3 = double.Parse(Console.ReadLine());
media = (n1 + n2 + n3) / 3;
//Arredonda para cima ou baixo
Console.WriteLine(Math.Round(media));
//Converte para string 
Console.WriteLine($"{media.ToString()}");
//Converte string F format
Console.WriteLine($"{media:F2}");