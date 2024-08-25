using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GerenciamentoLivros.API.Data;
using GerenciamentoLivros.API.Models;

namespace GerenciamentoLivros.API.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly AppDbContext _context;

        public LivroRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Livro>> GetAll()
        {
            return await _context.Livros.ToListAsync();
        }

        public async Task<Livro> GetById(int id)
        {
            return await _context.Livros.FindAsync(id);
        }

        public async Task Add(Livro livro)
        {
            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Livro livro)
        {
            _context.Entry(livro).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var livro = await _context.Livros.FindAsync(id);
            if (livro != null)
            {
                _context.Livros.Remove(livro);
                await _context.SaveChangesAsync();
            }
        }
    }
}
