using System.Linq;
using System.Threading.Tasks;
using TestApi.Core.Domain;

namespace TestApi.Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetByIdAsync(int id);
        IQueryable<TEntity> GetAll();
        Task AddAsync(TEntity entity);
        void Delete(TEntity entity);
        void Save();
    }
}
