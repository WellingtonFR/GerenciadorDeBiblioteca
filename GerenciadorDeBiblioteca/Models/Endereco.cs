using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeBiblioteca.Models
{
    public class Endereco
    {

        public int EnderecoId { get; set; }

        public int Rua { get; set; }

        public string Coluna { get; set; }

        public int Prateleira { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }

    }
}
