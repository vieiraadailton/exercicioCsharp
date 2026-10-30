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
//foreach (string fruta in frutas)
//{
//    Console.Write(fruta.ToLower() + ", ");

//}
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
    Console.Write("---------- Bem vindo ao menu! ----------\n\nPara prosseguirmos, digite uma opção:\n1. Adicionar itens\n2. Mostrar lista\n3. Atualizar item\n4. Remover item\n5. Ordenar lista\n6. Buscar item\n7. Sair\n----------------------------------------");
    int opcao = int.Parse(Console.ReadLine()!);
    

    switch (opcao)
    {
        case 1:
            //Estrutura para adicionar elementos
            Console.WriteLine("Deseja inserir uma fruta ao conjunto? S - Sim, N - Não");
            char inserir = char.Parse(Console.ReadLine()!.ToLower().Trim());

            if (inserir == 's')
            {
                Console.WriteLine("Digite o nome da fruta que deseja adicionar: ");
                string fruta = Console.ReadLine()!.ToLower().Trim();
                frutas.Add(fruta);
                break;
            }

            if (inserir == 'n')
            {
                break;
            }
            break;

        case 2:
            //Mostrar itens
            Console.WriteLine("Deseja visualizar a lista de itens? S - Sim, N - Não");
            char mostrar = char.Parse(Console.ReadLine()!.ToLower().Trim());

            if (mostrar == 's')
            {
                foreach (string fruta in frutas)
                {
                    Console.Write(fruta.ToLower() + ", ");

                }
                Console.WriteLine($"\nA lista atual possui: {frutas.Count()} itens.");
                break;
            }

            if (mostrar == 'n')
            {
                break;
            }
            break;

        case 3:
            //Estrutura para modificar em uma posicao especifica
            Console.WriteLine("Deseja alterar alguma fruta do conjunto? S - Sim, N - Não");
            char atualizar = char.Parse(Console.ReadLine()!.ToLower().Trim());

            if (atualizar == 's')
            {
                Console.WriteLine("Digite o nome da fruta que deseja alterar: ");
                string fruta = Console.ReadLine()!.ToLower().Trim();
                if (frutas.Contains(fruta))
                {

                    int posicao = frutas.IndexOf(fruta);
                    Console.WriteLine("Informe para qual nome deseja mudar: ");
                    string alteracao = Console.ReadLine()!.ToLower().Trim();
                    frutas[posicao] = alteracao;
                    Console.WriteLine($"A alteração foi realizada com sucesso: {fruta} agora é {alteracao}");
                }
                break;
            }

            if (atualizar == 'n')
            {
                break;
            }
            break;

        case 4:
            //Estrutura para remover elementos
            Console.WriteLine("Deseja remover alguma fruta do conjunto? S - Sim, N - Não");
            char remover = char.Parse(Console.ReadLine()!.ToLower().Trim());

            if (remover == 's')
            {
                Console.WriteLine("Digite o nome da fruta que deseja remover: ");
                string fruta = Console.ReadLine()!.ToLower().Trim();

                if (frutas.Contains(fruta) == true)
                {
                    Console.WriteLine("A fruta foi removida da lista");
                    frutas.Remove(fruta);
                }
                break;
            }

            if (remover == 'n')
            {
                break;
            }
            break;

        case 5:
            //Ordenar lista
            Console.WriteLine("Deseja ordenar o conjunto? S - Sim, N - Não");
            char ordenar = char.Parse(Console.ReadLine()!.ToLower().Trim());

            if (ordenar == 's')
            {
                Console.WriteLine("Selecione uma opção:\n1. Ordem Crescente\n2. Ordem Decrescente");
                int selecao = int.Parse(Console.ReadLine()!);
                if (selecao == 1)
                {
                    frutas.Sort();
                }
                else
                {
                    frutas.Sort();
                    frutas.Reverse();
                }
                break;
            }

            if (ordenar == 'n')
            {
                break;
            }
            break;
        case 6:
            //Buscar item na lista
            Console.WriteLine("Deseja buscar uma fruta? S - Sim, N - Não");
            char buscar = char.Parse(Console.ReadLine()!.ToLower().Trim());

            if (buscar == 's')
            {
                Console.WriteLine("Informe por qual fruta está buscando: ");
                string selecao = Console.ReadLine()!;
                if (frutas.Contains(selecao))
                {
                    Console.WriteLine("A fruta está na lista!");
                }
                else
                {
                    Console.WriteLine("A fruta não está lista.");
                }
            } 

            if(buscar == 'n')
            {
                break;
            }
            break;
        case 7:
            Console.WriteLine("Obrigado por utilizar nosso menu!");
            break;
        default:
            Console.WriteLine("Tente novamente! Informe um número válido.");
            break;
    }
    
        if(opcao == 7)
    {
        break;
    }
    


} while (continuar != false);
