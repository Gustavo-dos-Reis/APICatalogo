using APICatalogo.Pagination;

namespace APICatalogo.Filters
{
    public class ProdutosFiltroPreco : QueryStringParameters
    {
        public decimal? Preco { get; set; }
        public string? PrecoCriterio { get; set; } // "maior", "menor" ou "igual"
    }
}
