using System.Linq;

namespace LogisticsCenterAPI.Repository
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
    }
}
