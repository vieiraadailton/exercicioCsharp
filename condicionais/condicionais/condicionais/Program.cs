//Console.WriteLine("Estruturas condicionais!");
//if


//if (false)
//{
//    Console.WriteLine("O if foi executado com sucesso!");
//}
//Console.WriteLine("Fim do programa");

/* crie um programa que vai receber a idade e se possui titulo de eleitor para votar com base nas informacoes verifique se a pessoa pode votar*/

//bool temTitulo = true;
//Console.WriteLine("Insira a sua idade: ");
//int idade = int.Parse(Console.ReadLine());
//Console.WriteLine("Tem título? S - Sim / N - Não");
//char titulo = char.Parse(Console.ReadLine());
//if (idade >= 16 && idade <18 || idade >=70 && idade <=130 && temTitulo == true)
//{
//    Console.WriteLine("Voto facultativo.");
//    if(titulo != 's')
//    {
//        Console.WriteLine("Voce não é obrigado a votar.");
//    }
//} else if(idade >= 18 && idade < 70 && temTitulo == true)
//{
//    Console.WriteLine("Voto obrigatório.");
//    if(titulo != 's')
//    {
//        Console.WriteLine("Regularize seu título.");
//    }

//} else if (idade >= 0 && idade < 16)
//{
//    Console.WriteLine("Voce não pode votar.");
//}
//else
//{
//    Console.WriteLine("Insira uma idade válida.");
//}

/*
Leia uma nota de 0 a 10 (aceita decimais) sem deixar o programa quebrar. Use o double.TryParse no lugar de double.Parse.
O texto que nao é numero > "Entrada invalida: digite um numero"
Fora de 0 a 10 > "Nota fora da faixa (0 a 10)"
9 ou mais > conceito A; 7 ou mais > conceito B; 5 ou mais conceito C; abaixo de 5 > conceito D
*/

//Console.WriteLine("Insira sua nota: ");
//string resposta = Console.ReadLine();

//TryParse espera um texto para poder converte, logo, é necessário que o valor armazenado precisa ser uma string


//if(!double.TryParse(resposta, out double nota)){
//    Console.WriteLine("Entrada invalida: digite um numero");
//}
//else if (nota <0 && nota > 10)
//{
//    Console.WriteLine("Nota fora da faixa (0 a 10)");
//} else if(nota >= 9 && nota <= 10)
//{
//    Console.WriteLine("Conceito A");
//} else if(nota >= 7 && nota <9) 
//{
//    Console.WriteLine("Conceito B");
//} else if(nota >= 5 && nota <7)
//{
//    Console.WriteLine("Conceito C");
//} else if (nota < 5 && nota >=0)
//{
//    Console.WriteLine("Conceito D");
//}

/*
Leia a idade, se e estudante (s/n), o dia da semana (1=domingo...7=sabado) e se a sessao é 3d(s/n). Calcule o preco:
1. Preco base: R$ 40,00
2. Meia-entrada (50%) se a idade for menor que 12, maior ou igual a 60, ou se for estudante
3. As tercas (dia 3), mais 20% de ddesconto sobre o valor ja calculado.
4. Sessao 3d: soma R$ 8,00 depois dos descontos.
Idade fora de 0 a 120 -> "Idade invalida". Dia fora de 1 a 7 -> "Dia invalido"
*/
int preco = 40;
int valorMeia = (preco * 50) / 100;
Console.WriteLine("Informe sua idade: ");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("É estudante? S - Sim, N - Não");
char estudante = char.Parse(Console.ReadLine());
Console.WriteLine("Deseja sessão 3D? S - Sim, N - Não");
char tresD = char.Parse(Console.ReadLine());
Console.WriteLine("Informe o dia da semana que irá assistir: \n1. Domingo\n2. Segunda\n3. Terca\n4. Quarta\n5. Quinta\n6. Sexta\n7. Sabado");
int diaSemana = int.Parse(Console.ReadLine());

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

int dia = diaSemana;

if(idade <0 || idade > 120)
{
    Console.WriteLine("Idade inválida");
} else if (idade >= 0 && idade <=12 || idade >= 60 || estudante == 's' && dia != 3)
{
    Console.WriteLine($"Voce tem direito a meia-entrada!\nValor do ingresso: R${valorMeia}.");

    if (dia == 3)
    {
        int promo = valorMeia - ((valorMeia * 20) / 100);
        Console.WriteLine($"Voce escolheu o dia da promocao maluca e tem 20% de desconto! Valor atualizado: R$ {promo}");
    }
} else if (estudante == 'n' && dia != 3)
{
    Console.WriteLine($"Valor do ingresso: R${preco}");
    if(tresD == 's')
    {
        int total = preco + 8;
        Console.WriteLine($"Valor atualizado com sessão 3D: R${total}");
    }
} else if (dia == 3 && estudante == 's')
{
    int total = valorMeia + 8;
    Console.WriteLine($"Valor atualizado com sessão 3D: R${total}");
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