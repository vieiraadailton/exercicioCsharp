//Console.WriteLine("Estruturas condicionais!");
//if


//if (false)
//{
//    Console.WriteLine("O if foi executado com sucesso!");
//}
//Console.WriteLine("Fim do programa");

/* crie um programa que vai receber a idade e se possui titulo de eleitor para votar com base nas informacoes verifique se a pessoa pode votar*/

bool temTitulo = true;
Console.WriteLine("Insira a sua idade: ");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("Tem título? S - Sim / N - Não");
char titulo = char.Parse(Console.ReadLine());
if (idade >= 16 && idade < 18 || idade >= 70 && idade <= 130 && temTitulo == true)
{
    Console.WriteLine("Voto facultativo.");
    if (titulo != 's')
    {
        Console.WriteLine("Voce não é obrigado a votar.");
    }
}
else if (idade >= 18 && idade < 70 && temTitulo == true)
{
    Console.WriteLine("Voto obrigatório.");
    if (titulo != 's')
    {
        Console.WriteLine("Regularize seu título.");
    }

}
else if (idade >= 0 && idade < 16)
{
    Console.WriteLine("Voce não pode votar.");
}
else
{
    Console.WriteLine("Insira uma idade válida.");
}

/*
Leia uma nota de 0 a 10 (aceita decimais) sem deixar o programa quebrar. Use o double.TryParse no lugar de double.Parse.
O texto que nao é numero > "Entrada invalida: digite um numero"
Fora de 0 a 10 > "Nota fora da faixa (0 a 10)"
9 ou mais > conceito A; 7 ou mais > conceito B; 5 ou mais conceito C; abaixo de 5 > conceito D
*/

Console.WriteLine("Insira sua nota: ");
string resposta = Console.ReadLine();

//TryParse espera um texto para poder converte, logo, é necessário que o valor armazenado precisa ser uma string


if (!double.TryParse(resposta, out double nota))
{
    Console.WriteLine("Entrada invalida: digite um numero");
}
else if (nota < 0 && nota > 10)
{
    Console.WriteLine("Nota fora da faixa (0 a 10)");
}
else if (nota >= 9 && nota <= 10)
{
    Console.WriteLine("Conceito A");
}
else if (nota >= 7 && nota < 9)
{
    Console.WriteLine("Conceito B");
}
else if (nota >= 5 && nota < 7)
{
    Console.WriteLine("Conceito C");
}
else if (nota < 5 && nota >= 0)
{
    Console.WriteLine("Conceito D");
}

/*
Leia a idade, se e estudante (s/n), o dia da semana (1=domingo...7=sabado) e se a sessao é 3d(s/n). Calcule o preco:
1. Preco base: R$ 40,00
2. Meia-entrada (50%) se a idade for menor que 12, maior ou igual a 60, ou se for estudante
3. As tercas (dia 3), mais 20% de desconto sobre o valor ja calculado.
4. Sessao 3d: soma R$ 8,00 depois dos descontos.
Idade fora de 0 a 120 -> "Idade invalida". Dia fora de 1 a 7 -> "Dia invalido"
*/

int preco = 40;
int valorMeia = (preco * 50) / 100;
int valor3D = 8;
Console.WriteLine("Informe sua idade: ");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("É estudante? S - Sim, N - Não");
char estudante = char.Parse(Console.ReadLine());
Console.WriteLine("Deseja sessão 3D? S - Sim, N - Não");
char tresD = char.Parse(Console.ReadLine());
Console.WriteLine("Informe o dia da semana que irá assistir: \n1. Domingo\n2. Segunda\n3. Terca\n4. Quarta\n5. Quinta\n6. Sexta\n7. Sabado");
int diaSemana = int.Parse(Console.ReadLine());

if (idade < 0 || idade > 121)
{
    Console.WriteLine("Valor inválido. Tente novamente!");
}

if (estudante != 's' && estudante != 'n')
{
    Console.WriteLine("Valor inválido. Tente novamente!");
}

if (tresD != 's' && tresD != 'n')
{
    Console.WriteLine("Valor inválido. Tente novamente!");
}

if (diaSemana < 1 || diaSemana > 7)
{
    Console.WriteLine("Valor inválido. Tente novamente!");
}

switch (diaSemana)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Segunda-Feira");
        break;
    case 3:
        Console.WriteLine("Terca-Feira");

        if (idade >= 0 && idade <= 12 || idade >= 60 && idade < 121 || estudante == 's')
        {
            int valorIngresso = valorMeia - ((valorMeia * 20) / 100);
            Console.WriteLine($"Promoção da Terça maluca! Você tem 20% de desconto. Valor do ingresso: R${valorIngresso}");
            if (tresD == 's')
            {
                int valorIngresso3D = valorIngresso + valor3D;
                Console.WriteLine($"Você adquiriu a sessão 3D. Valor total: R${valorIngresso3D}");
            }

        }
        else if (idade > 12 || idade < 60 || estudante == 'n')
        {
            int valorIngresso = preco - ((preco * 20) / 100);
            Console.WriteLine($"Promoção da Terça maluca! Você tem 20% de desconto. Valor do ingresso: R${valorIngresso}");
            if (tresD == 's')
            {
                int total = valorIngresso + valor3D;
                Console.WriteLine($"Você adquiriu a sessão 3D. Valor total: R${total}");
            }
        }
        break;
    case 4:
        Console.WriteLine("Quarta-Feira");
        break;
    case 5:
        Console.WriteLine("Quinta-Feira");
        break;
    case 6:
        Console.WriteLine("Sexta-Feira");
        break;
    case 7:
        Console.WriteLine("Sabado");
        break;
}

if (idade >= 0 && idade <= 12 || idade >= 60 && idade < 121 || estudante == 's')
{
    ;
    Console.WriteLine($"Valor do ingresso: R${valorMeia}");
    if (tresD == 's')
    {
        int valorIngresso3D = valorMeia + valor3D;
        Console.WriteLine($"Você adquiriu a sessão 3D. Valor total: R${valorIngresso3D}");
    }

}
else if (idade > 12 || idade < 60 || estudante == 'n')
{

    Console.WriteLine($"Valor do ingresso: R${preco}");
    if (tresD == 's')
    {
        int total = preco + valor3D;
        Console.WriteLine($"Você adquiriu a sessão 3D. Valor total: R${total}");
    }
}


/*
Leia o limite da via e a velocidade medida (km/h, inteiros)
Calcule o percentual acima do limite com 

(velocidade - limite) * 100.0 / limite 

e classifique com uma switch:
0% ou menos -> dentro do limite
ate 20% -> infracao media
acima de 20 ate 50% -> infracao grave
acima de 50% -> infracao gravissima
limite menor ou igual a 0, ou velocidade negativa -> dados invalidos
*/

Console.WriteLine("Informe o limite da via: ");
int limite = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a velocidade medida: ");
int velocidade = int.Parse(Console.ReadLine());

if(limite <= 0  || velocidade <= 0)
{
    Console.WriteLine("Dados inválidos. Tente novamente.");
}
int multa = ((velocidade - limite) * 100) / limite;
switch (multa)
{
    case (<= 0):
        Console.WriteLine("Dentro do limite");
        break;
    case (< 20):
        Console.WriteLine("Infração média");
        break;
    case (< 50):
        Console.WriteLine("Infração grave");
        break;
    case (>= 50):
        Console.WriteLine("Infração gravíssima");
        break;
}