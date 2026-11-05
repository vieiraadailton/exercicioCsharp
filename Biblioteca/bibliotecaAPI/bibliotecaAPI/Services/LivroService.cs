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
    }
}
