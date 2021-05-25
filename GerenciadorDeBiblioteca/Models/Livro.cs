using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorDeBiblioteca.Models
{
    [Table("Livros")]
    public class Livro
    {

        public int LivroID { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string ISBN { get; set; }

        public string Editora { get; set; }

        public string Classificacao { get; set; }

        public string PalavrasChave { get; set; }


    }
}
