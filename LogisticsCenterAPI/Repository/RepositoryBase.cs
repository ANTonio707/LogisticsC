using LogisticsCenterAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LogisticsCenterAPI.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationDbContext RepositoryContext { get; set; }
        public RepositoryBase(ApplicationDbContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }
        public IQueryable<T> FindAll()  
        {
            return this.RepositoryContext.Set<T>().AsNoTracking();
        }
    }
}
