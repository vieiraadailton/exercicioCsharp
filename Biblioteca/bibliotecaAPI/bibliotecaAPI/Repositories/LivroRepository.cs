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
            using var conn = new SqliteConnection(_conexao);
            conn.Open();
            var comando = conn.CreateCommand();
            

            comando.CommandText = @"insert into livros (titulo, autor, ano_publicacao, disponivel) values ($nomeLivro, $nomeAutor, $ano, $dispo)";
            comando.Parameters.AddWithValue("$nomeLivro", livro.Titulo);
            comando.Parameters.AddWithValue("$nomeAutor", livro.Autor);
            comando.Parameters.AddWithValue("$ano", livro.AnoPublicacao);
            comando.Parameters.AddWithValue("$dispo", livro.LivroAlugado);
            comando.ExecuteNonQuery();
            return livro;
        }

        public bool AtualizarLivro(int id, Livro livro)
        {
            using var conn = new SqliteConnection(_conexao);
            conn.Open();
            var comando = conn.CreateCommand();


            comando.CommandText = @"update livros set titulo = $titulo, autor = $autor, ano_publicacao = $ano, disponivel = $dispo where idLivro = $id";
            comando.Parameters.AddWithValue("$titulo", livro.Titulo);
            comando.Parameters.AddWithValue("$autor", livro.Autor);
            comando.Parameters.AddWithValue("$ano", livro.AnoPublicacao);
            comando.Parameters.AddWithValue("$dispo", livro.LivroAlugado);
            comando.Parameters.AddWithValue("$id", id);

            int linhasModificadas = comando.ExecuteNonQuery();
            
            
            return linhasModificadas > 0; //Verificar se houve modificacao do conteudo
        }

        public bool DeletarLivro(int id)
        {
            using var conn = new SqliteConnection(_conexao);
            conn.Open();
            var comando = conn.CreateCommand();

            comando.CommandText = @"delete from livros where idLivro = $id";
            comando.Parameters.AddWithValue("$idLivro", id);
            int modificacao = comando.ExecuteNonQuery();

            return modificacao > 0;
        }

        public List<Livro> ListarTodosLivros()
        {
            List<Livro> livros = new List<Livro>();

            using var conn = new SqliteConnection(_conexao);
            conn.Open();

            var comando = conn.CreateCommand();
            comando.CommandText = @"SELECT idLivro, titulo, autor, ano_publicacao, disponivel
                                    FROM livros ORDER BY idLivro
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
