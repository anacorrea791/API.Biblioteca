using System.ComponentModel.DataAnnotations;

namespace API.Biblioteca.Models
{
    public class Genero
    {
        // id da classe deve ser o nome da classe + "Id"
        public Guid GeneroId { get; set; }

        [Required] // o campo nomoe e obrigatorio
        public string? Nome { get; set; }

        public ICollection<Livro>? Livros { get; set; }
    }
}
