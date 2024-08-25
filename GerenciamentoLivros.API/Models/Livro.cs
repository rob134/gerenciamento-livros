namespace GerenciamentoLivros.API.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }

        public Livro(string titulo, string autor, string genero)
        {
            Titulo = titulo;
            Autor = autor;
            Genero = genero;
        }
    }
}
