using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciamentoLivros.API.DTOs
{
    public class LivroDTO
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }

        public LivroDTO(string titulo, string autor, string genero)
        {
            Titulo = titulo;
            Autor = autor;
            Genero = genero;
        }
    }
}
