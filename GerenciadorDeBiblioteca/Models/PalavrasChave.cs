using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorDeBiblioteca.Models
{
    [Table("PalavrasChave")]
    public class PalavraChave
    {
        public int PalavraChaveID { get; set; }

        public string Palavra_Chave { get; set; }

        public Livro Livro { get; set; }
    }
}
