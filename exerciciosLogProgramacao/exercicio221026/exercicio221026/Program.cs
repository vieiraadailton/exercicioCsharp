///*
//https://sparkling-link-662.notion.site/Exerc-cios-Condicionais-34e1683796128091b664d6acdb0aa0ff
//## Nível Fácil

//1. **Temperatura**
//Leia uma temperatura em graus Celsius.
//Informe se está **frio** (abaixo de 15) ou **agradável/quente**.
//2. **Número válido**
//Leia um número.
//Informe se ele é maior que 100.
//3. **Senha simples**
//Leia uma senha (string).
//Verifique se ela é igual a `"123"`.
//4. **Número negativo**
//Leia um número.
//Se for negativo, mostre "Número inválido".
//5. **Ternário – positivo ou negativo**
//Leia a idade de uma pessoa e use operador ternário para mostrar:
//    - `"Cadastro permitido"` se tiver 16 anos ou mais
//    - `"Cadastro não permitido"` se tiver menos de 16 anos
//6. **Turno do dia (switch)**
    
//    Leia um número:
    
//    - 1 → Manhã
//    - 2 → Tarde
//    - 3 → Noite
//    Qualquer outro → Inválido
//7. **Menu simples (switch)**
    
//    Leia uma opção:
    
//    - 1 → "Novo jogo"
//    - 2 → "Carregar jogo"
//    - 3 → "Sair"

//---

//## Nível Médio

//1. **Classificação de idade**
//Leia a idade e classifique:
//    - Criança (até 12)
//    - Adolescente (13 a 17)
//    - Adulto (18 ou mais)
//2. **Maior entre dois (ternário)**
//Leia dois números e use operador ternário para mostrar o maior.
//3. **Acesso com duas condições**
//Leia:
//    - idade
//    - possui ingresso (true/false)
//    Só pode entrar se tiver mais de 18 **ou** possuir ingresso.
//4. **Número dentro de faixa inválida**
//Leia um número.
//Se estiver fora do intervalo de 0 a 10, mostrar "Valor inválido".
//5. **Desconto por idade**
//Leia a idade:
//    - Menor de 18 → sem desconto
//    - 18 a 59 → 10%
//    - 60 ou mais → 20%
//6. **Desconto com ternário**
    
//    Leia o valor de uma compra:
    
//    - >= 200 → 15% desconto
//    - < 200 → 5% desconto
//7. **Calculadora com switch**
    
//    Leia dois números e uma operação (+, -, *, /).
    
//8. **Dia útil ou fim de semana (switch)**
    
//    Leia um número de 1 a 7.
    
//    - 1 e 7 → Fim de semana
//    - 2 a 6 → Dia útil
//9. **Plano de internet (switch)**
    
//    Leia o plano:
    
//    - "Básico" → 10MB
//    - "Intermediário" → 50MB
//    - "Premium" → 100MB

//---

//## Nível Difícil

//1. **Sistema de notas completo**
//Leia a nota (0 a 10):
//    - >= 7 → Aprovado
//    - = 5 e < 7 → Recuperação
//    - < 5 → Reprovado
//    Se a nota for inválida (<0 ou >10), informar isso.
//2. **Triângulo (simplificado)**
//Leia três números.
//Verifique se todos são maiores que zero.
//Se sim, informe "Pode formar um triângulo", senão "Inválido".
//3. **Calculadora simples**
    
//    Leia:
    
//    - número 1
//    - número 2
//    - operador (+, -, *, /)
    
//    Execute a operação correspondente usando if/else.
    
//4. **Login com tentativas**
//Leia usuário e senha.
//Se estiver correto (usuário e senha), acesso liberado.
//Caso contrário, acesso negado.
//5. **Ternário encadeado (desafio)**
//Leia um número e classifique usando **apenas operador ternário**:
//    - Negativo
//    - Zero
//    - Positivo
//6. **Menu de operações completo (switch + if)**
    
//    Leia:
    
//    - número 1
//    - número 2
//    - operação (+, -, *, /)
    
//    Use `switch` para escolher a operação
    
//    e valide divisão por zero com `if`.
    
//7. **Escolha de bebida (switch)**
    
//    Leia uma opção:
    
//    - 1 → Água
//    - 2 → Refrigerante
//    - 3 → Suco
    
//    Mostre também o preço (você pode definir os preços de forma aleatória).

// */
//Facil
//1

//Console.WriteLine("Insira a temperatura atual: ");
//int temperatura = int.Parse(Console.ReadLine());
//if (temperatura < 15)
//{
//    Console.WriteLine("Está frio.");
//}
//else { Console.WriteLine("Está /quente."); }

//2
//Console.WriteLine("Informe um número: ");
//int n = int.Parse(Console.ReadLine());
//if (n > 100)
//{
//    Console.WriteLine("Maior que 100");
//}
//else
//{
//    Console.WriteLine("Menor que 100");
//}

//3
//Console.WriteLine("Insira a senha: ");
//string senha = Console.ReadLine();
//if (senha != "123")
//{
//    Console.WriteLine("Senha incorreta.");
//}
//else
//{
//    Console.WriteLine("Senha correta.");

//    4
//Console.WriteLine("Insira um número:");
//    int n = int.Parse(Console.ReadLine());
//    if (n >= 0)
//    {
//        Console.WriteLine("Número válido.");
//    }
//    else
//    {
//        Console.WriteLine("Número inválido.");
//    }

//    5
//Console.WriteLine("Insira a idade:");
//    int idade = int.Parse(Console.ReadLine());
//    string resultado = idade >= 16 ? "Cadastro permitido." : "Cadastro não permitido.";
//    Console.WriteLine(resultado);

//    6
//Console.WriteLine("Insira um numero de 1 a 3");
//    int menu = int.Parse(Console.ReadLine());
//    switch (menu)
//    {
//        case 1:
//            Console.WriteLine("Manhã");
//            break;
//        case 2:
//            Console.WriteLine("Tarde");
//            break;
//        case 3:
//            Console.WriteLine("Noite");
//            break;
//        default:
//            Console.WriteLine("Insira um número válido");
//            break;
//    }

//    7
//Console.WriteLine("Insira um numero de 1 a 3");
//    int menu = int.Parse(Console.ReadLine());
//    switch (menu)
//    {
//        case 1:
//            Console.WriteLine("Novo jogo");
//            break;
//        case 2:
//            Console.WriteLine("Carregar jogo");
//            break;
//        case 3:
//            Console.WriteLine("Sair");
//            break;
//        default:
//            Console.WriteLine("Insira um número válido");
//            break;
//    }

//    Medio
//1
//Console.WriteLine("Insira sua idade: ");
//    int idade = int.Parse(Console.ReadLine());
//    if (idade >= 0 && idade <= 12)
//    {
//        Console.WriteLine("Sua classificação é criança.");
//    }
//    else if (idade >= 13 && idade <= 17)
//    {
//        Console.WriteLine("Sua classificação é adolescente.");
//    }
//    else if (idade > 17)
//    {
//        Console.WriteLine("Sua classificação é adulto.");
//    }
//    else
//    {
//        Console.WriteLine("Digite um número válido.");
//    }

//    2
//Console.WriteLine("Insira dois números: ");
//    int n1 = int.Parse(Console.ReadLine());
//    int n2 = int.Parse(Console.ReadLine());

//    string resultado = n1 > n2 ? $"{n1} é maior que {n2}." : $"{n2} é maior que {n1}.";
//    Console.WriteLine(resultado);

//    3
//Console.WriteLine("Digite a idade: ");
//    int idade = int.Parse(Console.ReadLine());
//    Console.WriteLine("Possui ingresso? S - Para sim, N - Para não.");
//    char ingresso = char.Parse(Console.ReadLine());
//    if (ingresso == 'n' && idade < 18)
//    {
//        Console.WriteLine("Voce não pode entrar.");
//    }
//    else if (ingresso == 's' || idade >= 18)
//    {
//        Console.WriteLine("Você pode entrar");
//    }

//    4
//Console.WriteLine("Digite um número: ");
//    int n = int.Parse(Console.ReadLine());
//    if (n >= 0 && n <= 10)
//    {
//        Console.WriteLine("Número válido.");
//    }
//    else
//    {
//        Console.WriteLine("Não é um número válido.");
//    }

//    5

//Console.WriteLine("Digite sua idade: ");
//    int idade = int.Parse(Console.ReadLine());
//    if (idade < 18 && idade > 0)
//    {
//        Console.WriteLine("Você não tem desconto.");
//    }
//    else if (idade >= 18 && idade <= 59)
//    {
//        Console.WriteLine("Você possui 10% de desconto.");
//    }
//    else if (idade >= 60 && idade < 130)
//    {
//        Console.WriteLine("Você possui 20% de desconto.");
//    }
//    else
//    {
//        Console.WriteLine("Insira uma idade válida.");
//    }

//    //6

//Console.WriteLine("Digite o valor do produto: ");
//    int valor = int.Parse(Console.ReadLine());
//    int descontoQuinze = valor - ((valor * 15) / 100);
//    int descontoCinco = valor - ((valor * 5) / 100);
//    string resultado = valor >= 200 ? $"15% de desconto, novo valor: {descontoQuinze}" : $"5% de desconto, novo valor: {descontoCinco}";
//    Console.WriteLine(resultado);

//    //7
//float resultado;
//    Console.WriteLine("Insira dois números: ");
//    float n1 = float.Parse(Console.ReadLine());
//    float n2 = float.Parse(Console.ReadLine());
//    Console.WriteLine("Selecione a operação deseja: ");
//    char menu = char.Parse(Console.ReadLine());
//    switch (menu)
//    {
//        case '+':
//            resultado = n1 + n2;
//            Console.WriteLine($"{resultado}");
//            break;

//        case '-':
//            resultado = n1 - n2;
//            Console.WriteLine($"{resultado}");
//            break;

//        case '*':
//            resultado = n1 * n2;
//            Console.WriteLine($"{resultado}");
//            break;

//        case '/':
//            resultado = n1 / n2;
//            Console.WriteLine($"{resultado}");
//            break;
//        default:
//            Console.WriteLine("Insira uma opção válida");

//            break;
//    }

//    8
//Console.WriteLine("Insira um número de 1 a 7");
//    int n = int.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 1 or 7:
//            Console.WriteLine("Fim de semana");
//            break;
//        case 2 or 3 or 4 or 5 or 6:
//            Console.WriteLine("Dia útil");
//            break;

//        default:
//            Console.WriteLine("Insira um número válido");
//            break;
//    }

//    9
//Console.WriteLine("Digite um entre as opções. \n1. Basico\n2. Intermediario\n3. Premium");
//    string selecao = Console.ReadLine();
//    switch (selecao)
//    {
//        case "basico":
//            Console.WriteLine($"Você selecionou {selecao} - O plano básico com 10MB");
//            break;
//        case "intermediario":
//            Console.WriteLine($"Você selecionou {selecao} -  O plano intermediário com 50MB");
//            break;
//        case "premium":
//            Console.WriteLine($"Você selecionou {selecao} - O plano premium com 100MB");
//            break;
//        default:
//            Console.WriteLine("Insira um valor válido.");
//            break;
//    }

//    Dificil
//1
//Console.WriteLine("Informe sua nota: ");
//    float nota = float.Parse(Console.ReadLine());
//    if (nota >= 0 && nota < 5)
//    {
//        Console.WriteLine("Reprovado");
//    }
//    else if (nota >= 5 && nota < 7)
//    {
//        Console.WriteLine("Recuperação");
//    }
//    else if (nota >= 7 && nota <= 10)
//    {
//        Console.WriteLine("Aprovado");
//    }
//    else
//    {
//        Console.WriteLine("Insira uma nota válida entre 0 e 10.");
//    }

//    2
//Console.WriteLine("Insira três números: ");
//    int n1 = int.Parse(Console.ReadLine());
//    int n2 = int.Parse(Console.ReadLine());
//    int n3 = int.Parse(Console.ReadLine());
//    string res = n1 > 0 && n2 > 0 && n3 > 0 ? "Pode formar um triângulo" : "Inválido";
//    Console.WriteLine(res);

//    3
//Console.WriteLine("Insira dois números: ");
//    float n1 = float.Parse(Console.ReadLine());
//    float n2 = float.Parse(Console.ReadLine());
//    Console.WriteLine("Insira o operador desejado: ");
//    char operador = char.Parse(Console.ReadLine());

//    if (operador == '-')
//    {
//        float res = n1 - n2;
//        Console.WriteLine(res);
//    }
//    else if (operador == '+')
//    {
//        float res = n1 + n2;
//        Console.WriteLine(res);
//    }
//    else if (operador == '*')
//    {
//        float res = n1 * n2;
//        Console.WriteLine(res);
//    }
//    else if (operador == '/')
//    {
//        float res = n1 / n2;
//        Console.WriteLine(res);
//    }

//    4
//string user = "admin";
//    string password = "adm123";
//    Console.WriteLine("Informe seu usuário: ");
//    string usuario = Console.ReadLine();
//    Console.WriteLine("Informe a senha: ");
//    string senha = Console.ReadLine();
//    if (usuario != user && senha != password)
//    {
//        Console.WriteLine("Acesso negado");
//    }
//    else
//    {
//        Console.WriteLine("Acesso liberado");
//    }

//    5
//Console.WriteLine("Insira um número: ");
//    int n = int.Parse(Console.ReadLine());
//    string res = n == 0 ? "Zero" : (n < 0 ? "Negativo" : "Positivo");
//    Console.WriteLine(res);

//    6
//float resultado;
//    Console.WriteLine("Insira dois números: ");
//    float n1 = float.Parse(Console.ReadLine());
//    float n2 = float.Parse(Console.ReadLine());
//    Console.WriteLine("Selecione a operação deseja: ");
//    char menu = char.Parse(Console.ReadLine());
//    switch (menu)
//    {
//        case '+':
//            resultado = n1 + n2;
//            Console.WriteLine($"{resultado}");
//            break;

//        case '-':
//            resultado = n1 - n2;
//            Console.WriteLine($"{resultado}");
//            break;

//        case '*':
//            resultado = n1 * n2;
//            Console.WriteLine($"{resultado}");
//            break;

//        case '/':
//            if (n1 == 0 || n2 == 0)
//            {
//                Console.WriteLine("A operação não é válida.");
//            }
//            else
//            {
//                resultado = n1 / n2;
//                Console.WriteLine($"{resultado}");
//            }

//            break;
//        default:
//            Console.WriteLine("Insira uma opção válida");

//            break;
//    }

//    7
//Console.WriteLine("Selecione uma opção:\n1.Água\n2.Refrigerante\n3.Suco");
//    int opcao = int.Parse(Console.ReadLine());
//    Random valor = new Random();
//    int valorMax = valor.Next(10);
//    switch (opcao)
//    {
//        case 1:
//            Console.WriteLine($"Você escolheu água - R${valorMax},00.");
//            break;

//        case 2:
//            Console.WriteLine($"Você escolheu refrigerante - R${valorMax},00.");
//            break;

//        case 3:
//            Console.WriteLine($"Você escolheu suco - R${valorMax},00.");
//            break;
//    }