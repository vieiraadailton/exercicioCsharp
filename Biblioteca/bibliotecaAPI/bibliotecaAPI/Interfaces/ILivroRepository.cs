using bibliotecaAPI.Domains
namespace bibliotecaAPI.Interfaces
{
    //Por padrao, nomes de interfaces iniciam com I maiusculo;
    //Serve para dizer quais metodos utilizar, as acoes que serao tomadas baseadas no que o livro precisa fazer. Especifica quais metodos o programa tem que ter.
    //Interface - Listar operacoes que qualquer repositorio precisa ter, diz o que fazer; A classe repository diz COMO fazer
    public interface ILivroRepository
    {
        //Listar todos os livros
        List<Livro> ListarTodosLivros();
        Livro AdicionarLivro(Livro livro);
        bool AtualizarLivro(int id, Livro livro);
        bool DeletarLivro(int id);
    }
}
