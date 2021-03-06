using GerenciadorDeBiblioteca.Context;
using GerenciadorDeBiblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeBiblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LivrosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Livros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Livro>>> GetLivros()
        {
            return await _context.Livros.Include(p=>p.Endereco).ToListAsync();
        }

        // GET: api/Livros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Livro>> GetLivro(int id)
        {
            var livro = await _context.Livros.Include(p => p.Endereco).FirstOrDefaultAsync(p=>p.LivroId == id);

            if (livro == null)
            {
                return NotFound("Nenhum livro foi encontrado com os dados informados");
            }

            return livro;
        }

        // PUT: api/Livros/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLivro(int id, Livro livro)
        {
            if (id != livro.LivroId)
            {
                return BadRequest("Erro ao localizar o livro, requisicão com formato inválido");
            }

            _context.Entry(livro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LivroExists(id))
                {
                    return NotFound("Não foi possível atualizar os dados do livro, Nenhum livro foi encontrado com os dados informados");
                }
            }

            return NoContent();
        }

        // POST: api/Livros
        [HttpPost]
        public async Task<ActionResult<Livro>> PostLivro(Livro livro)
        {
            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();

            return  CreatedAtAction("GetLivro", new { id = livro.LivroId }, livro);
        }

        // DELETE: api/Livros/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLivro(int id)
        {
            var livro = await _context.Livros.FindAsync(id);
            if (livro == null)
            {
                return NotFound("Nenhum livro foi encontrado com os dados informados");
            }

            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LivroExists(int id)
        {
            return _context.Livros.Any(e => e.LivroId == id);
        }
    }
}
