using System.Threading.Channels;

string opcao;
int resultado;
do
{
    MostrarMenu();
    opcao = Console.ReadLine()!;
    if(!int.TryParse(opcao, out resultado))
    {
        
    }
    
    switch (resultado)
    {
        case 1:
            Somar();
            break;
        case 2:
            Subtrair();
            break;
        case 3:
            Multiplicar();
            break;
        case 4:
            Dividir();
            break;
        case 5:
            Console.WriteLine("Programa finalizado");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

} while (resultado != 5);
void Somar()
{
    double x ,y;
    Console.Write("Insira um numero: ");
    x = double.Parse(Console.ReadLine()!);
    Console.Write("Insira um segundo numero: ");
    y = double.Parse(Console.ReadLine()!);

    Console.Write($"Resultado: {x + y}");
}

void Subtrair()
{
    double x , y;
    Console.Write("Insira um numero: ");
    x = double.Parse(Console.ReadLine()!);
    Console.Write("Insira um segundo numero: ");
    y = double.Parse(Console.ReadLine()!);
    Console.Write($"Resultado: {x - y}");
}
void Multiplicar()
{
    double x , y;
    Console.Write("Insira um numero: ");
    x = double.Parse(Console.ReadLine()!);
    Console.Write("Insira um segundo numero: ");
    y = double.Parse(Console.ReadLine()!);
    Console.Write($"Resultado: {x * y}");
}
void Dividir()
{
    double x; 
    double y;
    Console.Write("Insira um numero: ");
    x = double.Parse(Console.ReadLine()!);
    Console.Write("Insira um segundo numero: ");
    y = double.Parse(Console.ReadLine()!);

    if(x == 0 ||  y == 0)
    {
        Console.WriteLine("Não é possível realizar a divisão por 0");
    }
    else
    {
        Console.Write($"Resultado: {x / y:f2}");
    }
    
}

void MostrarMenu()
{
    Console.WriteLine("\n=======================");
    Console.WriteLine("Bem-vindo ao menu");
    Console.WriteLine("=======================");
    Console.WriteLine("Selecione a operacao");
    Console.WriteLine("\n1. Soma");
    Console.WriteLine("2. Subtração");
    Console.WriteLine("3. Multiplicação");
    Console.WriteLine("4. Divisão");
    Console.WriteLine("5. Sair");
    Console.WriteLine("=======================");

}