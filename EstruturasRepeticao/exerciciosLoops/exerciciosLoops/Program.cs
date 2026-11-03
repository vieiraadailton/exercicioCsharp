/*
# Exercícios de Repetição

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
//for(int i = 1; i < 11; i++)
//{
//    Console.WriteLine(i);
//}

//2
//for(int i = 10; i > 0; i--)
//{
//    Console.WriteLine(i);
//}

//3
//Console.WriteLine("Insira um número: ");
//int n = int.Parse(Console.ReadLine()!);
//for(int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{n} x {i} = {n*i}");
//}

//4
//int numero = 1;
//while(numero <= 5)
//{
//    Console.WriteLine(numero);
//    numero++;
//}

//5
//int soma = 0;
//for(int i = 1; i <= 5; i++)
//{
//    soma += i;
//}
//Console.WriteLine($"O resultado é: {soma}");

//Médio
//1
//int soma = 0;
//for(int i = 0; i < 5; i++)
//{
//    Console.Write($"Insira o {i+1} número: ");
//    int n = int.Parse(Console.ReadLine()!);
//    soma += n;
//}
//Console.WriteLine($"\nO resultado da soma dos valores é: {soma}");

//2
//for(int i = 0; i <= 20; i++)
//{
//    Console.WriteLine(i);
//    i += 1;
//}

//3
string senha = "1234";
bool acertou = true;
do
{
    Console.WriteLine("Digite a senha:");
    string tentativa = Console.ReadLine()!;
    if(tentativa == senha)
    {
        Console.WriteLine("Senha errada! Tente novamente");
    }

} while (acertou != false);
Console.WriteLine("Parabens!");
//4


//5



//Difícil
//1

//2


//3


//4


//5

