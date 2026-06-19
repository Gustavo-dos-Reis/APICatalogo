using APICatalogo.Filters;
using APICatalogo.Pagination;
using APICatalogo.Properties.Models;
using X.PagedList;

namespace APICatalogo.Repositories
{
    public interface  IProdutoRepository : IRepository<Produto>
    {
        Task<IPagedList<Produto>> GetProdutosAsync(ProdutosParameters produtosParams);
        Task<IEnumerable<Produto>> GetProdutosPorCategoriaAsync(int id);
        Task<IPagedList<Produto>> GetProdutosFiltroPrecoAsync(ProdutosFiltroPreco produtosFiltroParams);
    }
}
