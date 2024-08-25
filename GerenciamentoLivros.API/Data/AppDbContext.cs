using Microsoft.EntityFrameworkCore;
using GerenciamentoLivros.API.Models;

namespace GerenciamentoLivros.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Livro> Livros { get; set; }
    }
}
