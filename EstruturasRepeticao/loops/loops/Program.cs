//Estrutura de repeticao
//for (variavel; condicao ; incremento)
//for (int seq = 0; seq < 10; seq++)
//{
//    Console.WriteLine($"Sequencia {seq}");
//}

//while (condicao)

/*Criar um programa que pergunte a idade do pericles*/
using System.Threading.Channels;

//Console.WriteLine("Digite a idade do Pericles: ");
//int idadePericles = int.Parse(Console.ReadLine()!); //O ! no final, serve para ignorar avisos.
//while (idadePericles != 57)
//{
//    Console.WriteLine("Errouuuuuuuuuuuuuuuuuuuuuuuu, tente novamente!");
//    Console.WriteLine(idadePericles > 57 ? "Tente uma idade menor" : "Tente uma idade maior");
//    idadePericles = int.Parse(Console.ReadLine()!);

//}
//Console.WriteLine("Parabens, voce acertou!");

//int idadePericles;
//do
//{
//    Console.WriteLine("Digite a idade do Pericles: ");
//    idadePericles = int.Parse(Console.ReadLine()!);
//    if (idadePericles == 57)
//    {
//        Console.WriteLine("Parabens, voce acertou!");
//        break;
//    }
//    Console.WriteLine(idadePericles > 57 ? "Tente uma idade menor" : "Tente uma idade maior");

//    idadePericles = int.Parse(Console.ReadLine()!);

//} while (idadePericles != 57);


//estrutura FOREACH -> usado principalmente em conjunto de arrays, colecoes e listas.

//string[] frutas = { "Abacaxi", "Amora", "Limao", "Laranja", "Banana", "Uva", "Melancia" }; //Indica que é uma matriz do tipo string


//try //tentativa
//{
//    //Console.WriteLine(frutas[0]);

//    //foreach (string fruta in frutas)
//    //{
//    //    Console.WriteLine(fruta);
//    //};

//    for(int fruta=0;fruta < frutas.Length; fruta++)
//    {
//        Console.WriteLine((frutas[fruta]));
//    }
//}
//catch (IndexOutOfRangeException) //tratativa do erro
//{
//    Console.WriteLine("Index fora do alcance!");
//}

//int[] numeros = { 2, 4, 6, 8, 10, 12 };
//int soma = 0;

//foreach (int numero in numeros)
//{

//    soma += numero;
//    Console.WriteLine(soma);
//}

/*Crie um programa que vai pedir um numero para o usuario e o programa deve mostrar a tabuada desse numero da seguinte maneira:
 5 x 1 = 5
5 x 2 = 10 ...
5 x 10 = 50

e faca com que o programa continue perguntando um numero para a tabuada ate que o usuario decida sair do programa
 */

//bool resposta = true;
//int acumulador;


//while(resposta != false)
//{
//    Console.Write("Digite um número: ");
//    int numero = int.Parse(Console.ReadLine()!);
//    for (int inicio = 1; inicio <= 10; inicio++)
//    {
//        acumulador = numero * inicio;
//        Console.WriteLine($"{numero} x {inicio} = {acumulador}");
//    }
//    Console.WriteLine("Deseja continuar? s - sim, n - não");
//    char continuar = char.Parse(Console.ReadLine()!.ToLower());
//    if(continuar == 'n')
//    {
//        break;
//    }
//}

//int resultado;
//for(int inicio = 1; inicio <= 10; inicio++)
//{
//    for(int meio = 1;  meio <= 10; meio++)
//    {
//        resultado = inicio * meio;
//        Console.WriteLine($"----{inicio} x {meio}---- = {resultado}");
//    }
//    Console.WriteLine($"------- {inicio} -------");
//}

//media com foreach
//1. faca um programa que leia 5 numeros e informe a soma e a media dos numeros.
//int[] numeros = new int[5];
//int soma = 0;

//for(int i = 0; i < numeros.Length ; i++)
//{
//    Console.Write($"Insira o {i+1} numero: ");
//    numeros[i] += int.Parse(Console.ReadLine()!);
//}
//foreach(int numero in numeros)
//{
//    soma += numero;
//}
//Console.WriteLine($"A soma dos números é: {soma} e a média é: {soma / numeros.Length}");

//2. Faca um programa que, dado um conjunto de N numeros, determine o menor valor, o maior valor e a soma dos valores
//Console.Write("Voce deseja inserir quantos números?");
//int soma = 0;

//int numero = int.Parse(Console.ReadLine()!);
//int[] numeros = new int[numero];

//for (int i =0; i < numeros.Length; i++)
//{
//    Console.Write($"Insira o {i+1} número: ");
//    numeros[i] = int.Parse(Console.ReadLine()!);

//}

//int menor = numeros[0];
//int maior = numeros[0];

//for (int i =0;i < numeros.Length; i++)
//{
//    if (numeros[i] < menor)
//    {
//        menor = numeros[i];
//    }
//    if (numeros[i] > maior)
//    {
//        maior = numeros[i];
//    }
//}

//foreach (int num in numeros)
//{
//    soma += num;
//}

//Console.WriteLine($"\nA soma dos números é: {soma}");
//Console.WriteLine($"O maior número é: {maior}");
//Console.WriteLine($"O menor número é: {menor}");

//3. Numa eleicao existem tres candidatos, faca um programa que peca o numero total de eleitores . Peca para cada eleitor votar e ao final mostrar o numero de votos de cada candidato
int candA = 0;
int candB = 0; 
int candC = 0;

Console.Write("Informe a quantidade total de eleitores: ");
int qtd = int.Parse(Console.ReadLine()!);
int[] votos = new int[qtd];
for(int i = 0; i < votos.Length; i++)
{
    Console.WriteLine($"Informe para quem deseja votar:\n1. Candidato A\n2. Candidato B\n3. Candidato C");
    votos[i] = int.Parse(Console.ReadLine()!);
}
foreach(int voto in votos)
{

    string numeroVoto = voto switch
    {
        1 => $"Candidato A", 
        2 => "Candidato B",
        3 => "Candidato C",
        _ => "Insira uma opção válida"
    };

    if (voto == 1)
    {
        candA++;
    } else if (voto == 2) 
    { candB++; 
    } else 
    { candC++; 
    }

}

if(candA > candB && candA > candC)
{
    Console.WriteLine("A ganhou!");
} else if (candB  > candA && candB > candC)
{
    Console.WriteLine("B ganhou!");
}
else if(candC > candA && candC < candB)
{
    Console.WriteLine("C ganhou!");
}
else
{
    Console.WriteLine("Houve um empate!");
}

Console.WriteLine($"O Candidato A recebeu {candA} votos, o Candidato B recebeu {candB} votos e o Candidato C recebeu {candC} votos!");