//Comando para utilizar as dependencias do banco de dados SQLite
using Microsoft.Data.Sqlite;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Channels;

//Verificar a conexão com o banco de dados

//conceito conhecido como data base first, que gera todas as dependencias, tabelas, relacionamentos dentro do proprio codigo

//Criar a tabela para trabalhar com a persistencia dos dados
var conn = new SqliteConnection("Data Source = frutas.db");
conn.Open();

//criar tabela
var criarTabela = conn.CreateCommand();
criarTabela.CommandText = @"CREATE TABLE IF NOT EXISTS frutas (

                            idFruta INTEGER PRIMARY KEY AUTOINCREMENT,
                            nomeFruta TEXT NOT NULL UNIQUE)";
criarTabela.ExecuteNonQuery();

Console.WriteLine($"Banco frutas criado em: {Path.GetFullPath("frutas.db")}");

// -------- MENU -------------
List<string> listaFrutas = new List<string>();
int opcao;
do
{
    MostrarMenu();
    string entrada = Perguntar("Opcao: ");

    if(!int.TryParse(entrada, out opcao))
    {
        opcao = -1;
    }

    switch (opcao)
    {
        case 1:
            ListarFrutas();
            break;
        case 2:
            AdicionarFrutas();
            break;
        case 3:
            AtualizarFrutas();
            break;
        case 4:
            DeletarFrutas();
            break;
        case 0:
            Console.WriteLine("Até mais");
            break;
        default:
            Console.WriteLine("Opcao inválida!");
            break;
    }

} while(opcao != 0);
void DeletarFrutas()
{
    Console.WriteLine("=== Lista de Frutas ===");
    ListarFrutas();

    Console.WriteLine("Informe qual fruta deseja remover: ");
    string fruta = Console.ReadLine()!;

    int posicao = listaFrutas.IndexOf(fruta);


    if (!listaFrutas.Contains(fruta))
    {
        Console.WriteLine("A fruta não existe ou não foi encontrada!");
    }
    else if (fruta == "")
    {
        Console.WriteLine("Nome da fruta vazio.");
    }
    else
    {
        //Atualizar a fruta no banco
        var deletar = conn.CreateCommand();
        deletar.CommandText = (@"delete from frutas where nomeFruta = $nomeFruta");
        deletar.Parameters.AddWithValue("$nomeFruta",posicao);
        deletar.ExecuteNonQuery();
        

        listaFrutas.RemoveAt(posicao);
        Console.WriteLine($"A fruta {fruta} foi removida com sucesso.");
    }
}
void AtualizarFrutas()
{
    Console.WriteLine("=== Lista de Frutas ===");
    ListarFrutas();

    Console.WriteLine("Informe qual fruta deseja atualizar: ");
    string fruta = Console.ReadLine()!;
   
        
    Console.WriteLine("Informe a nova fruta: ");
    string newFruta = Console.ReadLine()!.Trim().ToLower();

    int posicao = listaFrutas.IndexOf(fruta);
    
        
    if (posicao == -1)
    {
        Console.WriteLine("A fruta não existe ou não foi encontrada!");
    }
    else if (newFruta == "" ||  listaFrutas.Contains(newFruta))
    {
        Console.WriteLine("Nome da fruta vazio ou a fruta já existe na lista.");
    }
    else
    {
        //Atualizar a fruta no banco
        var atualizar = conn.CreateCommand();
        atualizar.CommandText = ("update frutas set nomeFruta = $novaFruta where nomeFruta = $antigaFruta");
        atualizar.Parameters.AddWithValue("$novaFruta", newFruta);
        atualizar.Parameters.AddWithValue("$antigaFruta", fruta);
        atualizar.ExecuteNonQuery();

        listaFrutas[posicao] = newFruta;
        Console.WriteLine($"A fruta {fruta} foi atualizada para {newFruta}");
    }

}

void AdicionarFrutas()
{
    Console.WriteLine("Informe qual fruta deseja adicionar a lista: ");
    string frutaNova = Console.ReadLine()!;

    if (listaFrutas.Contains(frutaNova))
    {
        Console.WriteLine("A fruta já existe na lista.");
    } else if(frutaNova == " ")
    {
        Console.WriteLine("O nome não pode ficar vazio.");
    }
    else
    {
        //1. banco
        var inserir = conn.CreateCommand();
        inserir.CommandText = @"insert into frutas(nomeFruta) values ($nomeFruta)"; //$nomeFruta vira um parametro para que possa ser adicionado ao banco de dados, já que por padrão o BD não reconhece o valor da variável.
        inserir.Parameters.AddWithValue("$nomeFruta", frutaNova); //faz a adicao do valor novo ao parametro para que seja salvo no BD
        inserir.ExecuteNonQuery(); //faz a execucao da query

        //2. adiciona na lista
        listaFrutas.Add(frutaNova);
        Console.WriteLine($"{frutaNova} foi adicionada a lista.");
    }
}

void ListarFrutas()
{
    listaFrutas = new List<string>();
    //Montagem do comando para executar a query a partir da conexao com o bd
    var selecionarFrutas = conn.CreateCommand();
    selecionarFrutas.CommandText = "select nomeFruta from frutas order by nomeFruta asc ";

    //executar a query
    var leitor = selecionarFrutas.ExecuteReader(); //Retorna uma lista de valores a partir da mensagem do select e armazena em leitor

    while (leitor.Read()) {
        listaFrutas.Add(leitor.GetString(0)); //get string converte para o tipo string ,para inserir no bd e o 0 representa a coluna que será inserido

        foreach (var f in listaFrutas)
        {
            Console.WriteLine($"{f}");
        }
    }

}
string Perguntar(string mensagem)
{
    Console.Write(mensagem);
    return (Console.ReadLine()!.Trim());
}

void MostrarMenu()
{
    Console.WriteLine();
    Console.WriteLine("===== FRUTAS =====");
    Console.WriteLine("[1] - Listar Frutas");
    Console.WriteLine("[2] - Adicionar Frutas");
    Console.WriteLine("[3] - Atualizar Frutas");
    Console.WriteLine("[4] - Remover Frutas");
    Console.WriteLine("[5] - Verificar se existe");
    Console.WriteLine("[6] - Ordenar");
    Console.WriteLine("[0] - Sair");
}