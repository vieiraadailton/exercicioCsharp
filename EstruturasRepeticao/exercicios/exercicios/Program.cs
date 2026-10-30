/*
## Nível Fácil

1. **Contagem crescente (for)**
Mostre na tela os números de 1 até 10.
2. **Contagem regressiva (for)**
Mostre os números de 10 até 1.
3. **Tabuada simples (for)**
Leia um número e mostre a tabuada dele de 1 a 10.
4. **Repetição com while**
Mostre os números de 1 até 5 usando `while`.
5. **Soma até 5 (for)**
Some os números de 1 até 5 e mostre o resultado.

---

## Nível Médio

1. **Soma de números digitados (for)**
Peça 5 números ao usuário e mostre a soma total.
2. **Contar pares (for)**
Mostre todos os números pares de 1 até 20.
3. **Validação de senha (while)**
Peça uma senha até que o usuário digite `"1234"` corretamente.
4. **Menu com repetição (do while)**
Crie um menu:
    - 1 → Mostrar mensagem
    - 2 → Sair
    O programa deve repetir até escolher sair.
5. **Média de valores (for)**
Leia 4 números e calcule a média.

---

## Nível Difícil

1. **Maior número digitado (for)**
Leia 5 números e mostre qual é o maior.
2. **Contagem com condição (while)**
Leia números até o usuário digitar 0.
Mostre quantos números foram digitados (sem contar o 0).
3. **Soma até número negativo (while)**
Leia números e some todos até que seja digitado um número negativo.
4. **Percorrendo array (foreach)**
Crie um array com 5 números e mostre todos eles na tela.
5. **Média com foreach**
Crie um array com notas e calcule a média usando `foreach`.
 */

//Fácil
//1
//for(int i = 1; i < 10; i++)
//{
//    Console.WriteLine(i);
//}

//2
//for(int i = 10; i > 0; i--)
//{
//    Console.WriteLine(i);
//}

//3
//Console.WriteLine("Informe um número: ");
//int n = int.Parse(Console.ReadLine()!);
//for(int i = 1 ; i <= 10; i++)
//{
//    Console.WriteLine($"{i} x {n} = {i * n}");
//}

//4
//int inicio = 1;
//while (inicio <=5)
//{


//    Console.WriteLine(inicio);
//    inicio++;
//}

//5
//int soma = 0;
//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine(i);
//    soma += i;
//}
//Console.WriteLine($"Total: {soma}");

//Medio
//1
//int soma = 0;
//for(int i = 1; i < 6; i++)
//{
//    Console.WriteLine($"Insira o {i}° número: ");
//    int numero = int.Parse(Console.ReadLine()!);
//    soma += numero;
//}
//Console.WriteLine($"Total: {soma}");

//2
//for(int i = 1; i < 21; i++)
//{
//    i++;
//    Console.WriteLine(i);
//}

//3
//int senha = 1234;
//while (true)
//{
//    Console.WriteLine("Insira a senha: ");
//    int escolha = int.Parse(Console.ReadLine()!);
//    if (escolha != senha)
//    {
//        Console.WriteLine("Senha incorreta, tente novamente!");
//    }
//    else
//    {
//        Console.WriteLine("Você acertou!");
//        break;
//    }

//}

//4

//do
//{
//    Console.WriteLine("Informe uma opção:\n1. Mostrar mensagem\n2. Sair");
//    int escolha = int.Parse(Console.ReadLine()!);
//    if (escolha == 1)
//    {
//        Console.WriteLine("Bem-vindo!");
//    }

//    if (escolha == 2)
//    {
//        break;
//    }

//} while (true);

//5
//double media = 0;
//for(int i = 0; i<4; i++)
//{
//    Console.WriteLine($"Informe o {i+1}° número: ");
//    double n = double.Parse(Console.ReadLine()!);
//    media += n;
//}
//Console.WriteLine($"A média é: {media/4:f2}");

//Dificil
//1
//int maior = 1;
//for(int i = 0; i < 5; i++)
//{

//    Console.Write($"Insira o {i+1}° número: ");
//    int resposta = int.Parse(Console.ReadLine()!);
//    if (maior < resposta)
//    {
//        maior = resposta;
//    }
//}
//Console.WriteLine(maior);

//2
using static System.Runtime.InteropServices.JavaScript.JSType;
//List<string> numeros = new List<string>();
//while (true)
//{

//    Console.Write("Insira um número: ");
//    string numero = Console.ReadLine()!;
//    if (numero == "0")
//    {
//        break;
//    }
//    else
//    {
//        numeros.Add(numero);

//    }

//}
//foreach (string n in numeros)
//{
//    Console.Write($"{n},");
//}

//3
//int soma = 0;
//while (true)
//{
//    Console.Write("Insira um número: ");
//    int numero = int.Parse(Console.ReadLine()!);
//    if(numero < 0)
//    {
//        break;
//    }
//    else
//    {
//        soma += numero;
//    }
    
//}
//Console.WriteLine($"Total: {soma}");

//4
//int[] numeros = { 8,35,90,1000,25};

//foreach (int n in numeros)
//{
//    Console.Write($"{n},");
//}

//5
//double[] notas = {10,5,8,9,2};
//double somar = 0;

//foreach (double n in notas)
//{
//    somar += n;
//}

//double media = somar / 5;
//Console.WriteLine($"Média: {media:f1}");