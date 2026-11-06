namespace bibliotecaAPI.Domains;


// DOMAIN - representa um livro (cada linha vira um objeto Livro)
// ENTIDADE Livro
// Representacao de uma tabela no banco de dados
public class Livro
{
    public int IdLivro { get; set; }
    public string Titulo { get; set; } = string.Empty; //caso não seja passado nenhum argumento, permanecerá vazio ao invés de nulo.
    public string Autor { get; set; } = string.Empty;
    public int AnoPublicacao { get; set; }
    public bool LivroAlugado { get; set; }

}
