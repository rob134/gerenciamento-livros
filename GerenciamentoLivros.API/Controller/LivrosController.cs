using Microsoft.AspNetCore.Mvc;
using GerenciamentoLivros.API.Models;
using GerenciamentoLivros.API.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciamentoLivros.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroRepository _livroRepository;

        public LivrosController(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Livro>>> Get()
        {
            var livros = await _livroRepository.GetAll();
            return Ok(livros);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Livro>> Get(int id)
        {
            var livro = await _livroRepository.GetById(id);
            if (livro == null)
            {
                return NotFound();
            }
            return Ok(livro);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Livro livro)
        {
            await _livroRepository.Add(livro);
            return CreatedAtAction(nameof(Get), new { id = livro.Id }, livro);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Livro livro)
        {
            if (id != livro.Id)
            {
                return BadRequest();
            }
            await _livroRepository.Update(livro);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _livroRepository.Delete(id);
            return NoContent();
        }
    }
}
