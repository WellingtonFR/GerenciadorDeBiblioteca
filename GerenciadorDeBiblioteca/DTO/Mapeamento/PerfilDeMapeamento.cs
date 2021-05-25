using AutoMapper;
using GerenciadorDeBiblioteca.Models;
using GerenciadorDeBiblioteca.DTO;

namespace APICatalogo.DTO.Mapping
{
    public class PerfilDeMapeamento : Profile
    {
        public PerfilDeMapeamento()
        {
            CreateMap<Livro, LivroDTO>().ReverseMap();
        }
    }
}