using System.Linq.Expressions;

namespace Identity.EntityFrameworkCore.Repository;

public interface IRepositoryBase<T>
{
    IQueryable<T> GetAll();
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}