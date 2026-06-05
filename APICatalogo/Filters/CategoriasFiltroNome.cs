using APICatalogo.Pagination;

namespace APICatalogo.Filters
{
    public class CategoriasFiltroNome : QueryStringParameters
    {
        public string? Nome { get; set; }
    }
}
