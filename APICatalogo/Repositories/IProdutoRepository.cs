using APICatalogo.Filters;
using APICatalogo.Pagination;
using APICatalogo.Properties.Models;

namespace APICatalogo.Repositories
{
    public interface  IProdutoRepository : IRepository<Produto>
    {
        PagedList<Produto> GetProdutos(ProdutosParameters produtosParams);
        IEnumerable<Produto> GetProdutosPorCategoria(int id);
        PagedList<Produto> GetProdutosFiltroPreco(ProdutosFiltroPreco produtosFiltroParams);
    }
}
