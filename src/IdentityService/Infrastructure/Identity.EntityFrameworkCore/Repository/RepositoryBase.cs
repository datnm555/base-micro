using System.Linq.Expressions;

namespace Identity.EntityFrameworkCore.Repository;

public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    private readonly ApplicationDbContext _context;

    public RepositoryBase(ApplicationDbContext context)
    {
        _context = context;
    }

    public IQueryable<T> GetAll() => _context.Set<T>();

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
        _context.Set<T>().Where(expression);

    public void Create(T entity) => _context.Set<T>().Add(entity);

    public void Update(T entity) => _context.Update(entity);

    public void Delete(T entity) => _context.Set<T>().Remove(entity);
}