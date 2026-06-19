using System.Linq.Expressions;

namespace APICatalogo.Repositories
{
    public interface IRepository<T>
    {
        //precisa acessar dados no banco
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate);
        //Não acessam o banco de dados. Realizam as operações na memória
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity); 
    }
}
