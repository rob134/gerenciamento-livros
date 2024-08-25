using System.Collections.Generic;
using System.Threading.Tasks;
using GerenciamentoLivros.API.Models;

namespace GerenciamentoLivros.API.Repositories
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> GetAll();
        Task<Livro> GetById(int id);
        Task Add(Livro livro);
        Task Update(Livro livro);
        Task Delete(int id);
    }
}
