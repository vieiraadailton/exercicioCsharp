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

int idadePericles;
do
{
    Console.WriteLine("Digite a idade do Pericles: ");
    idadePericles = int.Parse(Console.ReadLine()!);
    if (idadePericles == 57)
    {
        Console.WriteLine("Parabens, voce acertou!");
        break;
    }
    Console.WriteLine(idadePericles > 57 ? "Tente uma idade menor" : "Tente uma idade maior");

    idadePericles = int.Parse(Console.ReadLine()!);

} while (idadePericles != 57);
