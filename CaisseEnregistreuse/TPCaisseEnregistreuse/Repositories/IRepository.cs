using System.Linq.Expressions;

namespace TPCaisseEnregistreuse.Repositories
{
    public interface IRepository<TEntity>
    {

        bool Add(TEntity entity);

        TEntity? GetById(int id);
        TEntity? Get(Expression<Func<TEntity, bool>> expression);
        List<TEntity> GetAll();
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> expression);

        bool Update(TEntity entity);
        bool Delete(int id);
    }
}
