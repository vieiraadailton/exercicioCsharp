using bibliotecaAPI.Domains;
using bibliotecaAPI.Interfaces;

namespace bibliotecaAPI.Services
{
    public class LivroService
    {
        //Variavel de somente leitura e privada, nao podendo ser acessada por outros metodos
        private readonly ILivroRepository _livroRepository;

        //Manipula as caracteristicas que estao privadas
        public LivroService(ILivroRepository livroRepository) {
            _livroRepository = livroRepository;
        }

        public List<Livro> Listar()
        {
            return _livroRepository.ListarTodosLivros();
        }

        public Livro Adicionar(Livro livro)
        {
            return _livroRepository.AdicionarLivro(livro);
        }

        public bool Atualizar(int id,Livro livro) {
            return _livroRepository.AtualizarLivro(id, livro);
        }

        public bool Deletar(int id)
        {
            return _livroRepository.DeletarLivro(id);
        }
    }
}
