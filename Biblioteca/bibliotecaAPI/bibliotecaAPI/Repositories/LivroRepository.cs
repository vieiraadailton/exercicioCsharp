using bibliotecaAPI.Domains;
using bibliotecaAPI.Interfaces;
using Microsoft.Data.Sqlite;

namespace BibliotecaAPI.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        // Criação da conexão do endereço com o banco de dados "biblioteca.db"
        private readonly string _conexao = "Data Source = biblioteca.db";

        public LivroRepository()
        {
            CriarTabela();
        }

        private void CriarTabela()
        {
            using var conexao = new SqliteConnection(_conexao);
            conexao.Open();

            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                CREATE TABLE IF NOT EXISTS livros (
                idLivro INTEGER PRIMARY KEY AUTOINCREMENT,
                titulo TEXT NOT NULL,
                autor  TEXT NOT NULL,
                ano_publicacao INTEGER NOT NULL,
                disponivel INTEGER NOT NULL DEFAULT 1)";

            comando.ExecuteNonQuery();
        }

        public Livro AdicionarLivro(Livro livro)
        {
            throw new NotImplementedException();
        }

        public bool AtualizarLivro(int id, Livro livro)
        {
            throw new NotImplementedException();
        }

        public bool DeletarLivro(int id)
        {
            throw new NotImplementedException();
        }

        public List<Livro> ListarTodosLivros()
        {
            List<Livro> livros = new List<Livro>();

            using var conn = new SqliteConnection(_conexao);
            conn.Open();

            var comando = conn.CreateCommand();
            comando.CommandText = @"SELECT idLivro, titulo, autor, ano_publicao, disponivel
                                    FROM livro ORDER BY idLivro
";

            using var leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                livros.Add(LerLivro(leitor));
            }


            return livros;
        }

        //faz a conversao dos dados para objeto
        private Livro LerLivro(SqliteDataReader leitor)
        {
            return new Livro
            {
                IdLivro = leitor.GetInt32(0),
                Titulo = leitor.GetString(1),
                Autor = leitor.GetString(2),
                AnoPublicacao = leitor.GetInt32(3),
                LivroAlugado = leitor.GetBoolean(4)
            };
        }
    }
}
