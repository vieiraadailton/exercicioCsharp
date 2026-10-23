/*
https://sparkling-link-662.notion.site/Exerc-cios-Condicionais-34e1683796128091b664d6acdb0aa0ff
## Nível Fácil

1. **Temperatura**
Leia uma temperatura em graus Celsius.
Informe se está **frio** (abaixo de 15) ou **agradável/quente**.
2. **Número válido**
Leia um número.
Informe se ele é maior que 100.
3. **Senha simples**
Leia uma senha (string).
Verifique se ela é igual a `"123"`.
4. **Número negativo**
Leia um número.
Se for negativo, mostre "Número inválido".
5. **Ternário – positivo ou negativo**
Leia a idade de uma pessoa e use operador ternário para mostrar:
    - `"Cadastro permitido"` se tiver 16 anos ou mais
    - `"Cadastro não permitido"` se tiver menos de 16 anos
6. **Turno do dia (switch)**
    
    Leia um número:
    
    - 1 → Manhã
    - 2 → Tarde
    - 3 → Noite
    Qualquer outro → Inválido
7. **Menu simples (switch)**
    
    Leia uma opção:
    
    - 1 → "Novo jogo"
    - 2 → "Carregar jogo"
    - 3 → "Sair" 

 */

//1

//Console.WriteLine("Insira a temperatura atual: ");
//int temperatura = int.Parse(Console.ReadLine());
//if (temperatura < 15)
//{
//    Console.WriteLine("Está frio.");
//} else { Console.WriteLine("Está /quente."); }

//2
//Console.WriteLine("Informe um número: ");
//int n = int.Parse(Console.ReadLine());
//if (n > 100) {
//    Console.WriteLine("Maior que 100");
//} else
//{
//    Console.WriteLine("Menor que 100");
//}

//3
//Console.WriteLine("Insira a senha: ");
//string senha  = Console.ReadLine();
//if (senha != "123")
//{
//    Console.WriteLine("Senha incorreta.");
//} else
//{
//    Console.WriteLine("Senha correta.");

//4
//Console.WriteLine("Insira um número:");
//int n = int.Parse(Console.ReadLine());
//if (n >= 0)
//{
//    Console.WriteLine("Número válido.");
//} else
//{
//    Console.WriteLine("Número inválido.");
//}

//5
//Console.WriteLine("Insira a idade:");
//int idade = int.Parse(Console.ReadLine());
//string resultado = idade >= 16 ? "Cadastro permitido." : "Cadastro não permitido.";
//Console.WriteLine(resultado);

//6
//Console.WriteLine("Insira um numero de 1 a 3");
//int menu = int.Parse(Console.ReadLine());
//switch (menu)
//{
//    case 1:
//        Console.WriteLine("Manhã");
//        break;
//    case 2:
//        Console.WriteLine("Tarde");
//        break;
//    case 3:
//        Console.WriteLine("Noite");
//        break;
//    default:
//        Console.WriteLine("Insira um número válido");
//        break;
//}

//7
Console.WriteLine("Insira um numero de 1 a 3");
int menu = int.Parse(Console.ReadLine());
switch (menu)
{
    case 1:
        Console.WriteLine("Novo jogo");
        break;
    case 2:
        Console.WriteLine("Carregar jogo");
        break;
    case 3:
        Console.WriteLine("Sair");
        break;
    default:
        Console.WriteLine("Insira um número válido");
        break;
}