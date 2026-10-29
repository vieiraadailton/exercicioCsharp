////Listas e Arrays

////Array -> Estrututra de dados unidimensional que aceita um único tipo de dado (int, string, bool, obj...), com tamanho fixo que é definida no momento da criacao.

////criacao int[] nomeVariavel = {colecao de dados}
////int[] valores = { 15, 20, 36 };

////Nao funciona devido o array ja estar definido por um tamanho fixo
////valores[3] = 3;

////atualiza a posicao 0
////valores[0] = 35;

////exibindo os dados por posicao;
////Console.WriteLine(valores[0]);

////exibir completo;
////foreach (var v in valores)
////{
////    Console.WriteLine(v);
////}

////define um espaco na memoria com capacidade para armazenar 5 dados 
////int[] valores = new int[5];

//////automatizando tarefas com o for, percorrendo atraves do tamanho do array e posicionando novos dados nas posicoes.
////for (int i = 0; i < valores.Length; i++)
////{
////    Console.Write($"Informe o {i+1} valores: ");
////    valores[i] = int.Parse(Console.ReadLine()!);
////}

////foreach (int i in valores)
////{
////    Console.Write(i + "  ");
////}

////Listas -> nao faz alocacao de memoria, é dinamica e seu tamanho pode ser aumentado
////criar
//List<int> lista = new List<int> { 10,20,30,40};

////list[4] = 50 //nao funciona

////metodos de lista - para manipular a lista. 
//lista.Add(50); //Acrescenta o valor ao final da lista;
//lista.Insert(0, 5);//Insere na posicao determinada 0 um novo valor 5
//lista.Count(); //Para contar o tamanho da lista

////remover valores dentro de listas (remove, removeAt, removeAll, clear)
//lista.Remove(10);//Remove um elemento que seja igual a 10 da lista, caso hajam dois valores iguais, remove a primeira ocorrencia.
//lista.RemoveAll(x => x == 10);//Remove todos os elementos que sao iguais a expressao.
//lista.RemoveAt(0); //Remove o elemento no indice 0

////buscar e consultar -> verificar se o valor existe (contains, indexOf, find, findIndex, exists, FindAll)

//lista.Contains(20); //útil para ser utilizado com if, retorna true ou false, é usado para saber se algo contem dentro da lista
//lista.IndexOf(40); //retorna em qual indice está o valor buscado
//lista.Find(x => x == 25);//procura pelo elemento baseado na condicao da funcao e retorna o proprio item, caso nao exista, retorna 0
//lista.FindIndex((x => x == 30)); //retorna o indice buscado baseado na condicao
//lista.Exists((x=>x == 30)); //retorna bool verificando se existe ou nao o elemento buscado

////metodos de ordenacao -> sort, reverse
//lista.Sort(); //deixa em ordem ascendente
//lista.Reverse(); //deixa em ordem decrescente

//Console.WriteLine(lista[0]);

////foreach(var item in list)
////{
////    Console.WriteLine(item.Count());
////}

/*

Criar um programa para manipulacao de dados usando listas
1. criar uma lista de frutas
2. adicionar, remover, verificar se um elemento esta na lista, atualizar uma fruta existente, para isso, utilize as estruturas
 
*/
bool continuar = true;

List<string> frutas = new List<string> { "laranja", "morango", "mamao", "limao", "pera", "manga" };
foreach (string fruta in frutas)
{
    Console.Write(fruta.ToLower() + ", ");

}
//Console.WriteLine($"\nA lista atual possui: {frutas.Count()} itens.");

//frutas.Add("banana");

//foreach (string fruta in frutas)
//{
//    Console.Write(fruta + ", ");
//}
//Console.WriteLine($"\nAgora, lista possui: {frutas.Count()} itens.");

//List<string> frutas = new List<string>();
do
{

    //Estrutura para adicionar elementos
    //Console.WriteLine("Deseja inserir uma fruta ao conjunto? S - Sim, N - Não");
    //char resposta = char.Parse(Console.ReadLine()!.ToLower().Trim());

    //if (resposta == 's')
    //{
    //    Console.WriteLine("Digite o nome da fruta que deseja adicionar: ");
    //    string fruta = Console.ReadLine()!.ToLower();
    //    frutas.Add(fruta);
    //    break;
    //}

    //if (resposta == 'n')
    //{
    //    break;
    //}

    //Estrutura para remover elementos
    Console.WriteLine("Deseja remover alguma fruta do conjunto? S - Sim, N - Não");
    char resposta = char.Parse(Console.ReadLine()!.ToLower().Trim());
   
    if (resposta == 's')
    {
        Console.WriteLine("Digite o nome da fruta que deseja remover: ");
        string fruta = Console.ReadLine()!.ToLower().Trim();

        if(frutas.Contains(fruta) == true)
        {
            Console.WriteLine("A fruta existe na lista");
            frutas.Remove(fruta);
        }
        break;
    } 

    if (resposta == 'n')
    {
        break;
    }

} while (continuar != false);

foreach (string fruta in frutas)
{
    Console.Write(fruta.ToLower() + ", ");

}
Console.WriteLine($"\nA lista atual possui: {frutas.Count()} itens.");