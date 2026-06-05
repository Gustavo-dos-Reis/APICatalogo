using APICatalogo.Filters;
using APICatalogo.Pagination;
using APICatalogo.Properties.Models;
using System.Runtime.InteropServices;

namespace APICatalogo.Repositories
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        PagedList<Categoria> GetCategorias(CategoriasParameters categoriasParams);
        PagedList<Categoria> GetCategoriasFiltroNome(CategoriasFiltroNome categoriasParams);
    }
}