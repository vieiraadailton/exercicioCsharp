using bibliotecaAPI.Services;
using bibliotecaAPI.Domains;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.Mvc.Routing;
using System.Linq.Expressions;

//Responsavel por controlar o fluxo de acesso para acesso de outras aplicacoes com o crud
//Recebe as requisicoes HTTP e devolve as respostas (JSON)

namespace bibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LivroController : Controller
    {
        private readonly LivroService _service;


        public LivroController(LivroService service)
        {
            _service = service;
        }

        [HttpGet]
        //Construcao do Endpoin apos definido qual metodo sera utilizado
        public ActionResult Listar() //
        {
            List<Livro> livros = _service.Listar();
            return Ok(livros); //Retorna o status de ok
        }

        [HttpPost]
        public ActionResult Adicionar(Livro livro)
        {
            try
            {
                Livro novoLivro = _service.Adicionar(livro);
                return Ok(novoLivro);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut("{id}")]
        public ActionResult Atualizar(int id, Livro livro)
        {
            try
            {
                bool atualizarLivro = _service.Atualizar(id, livro);

                if (!atualizarLivro)
                {
                    return NotFound("Livro não encontrado");
                }

                return Created("Livro atualizado", atualizarLivro);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [HttpDelete("{id}")]
        public ActionResult Deletar(int id)
        {
            try
            {
                bool livroDeletado = _service.Deletar(id);

                if (!livroDeletado)
                {
                    return NotFound("Livro não encontrado");
                }
                return Created("Livro deletado com sucesso", livroDeletado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 
    }
}