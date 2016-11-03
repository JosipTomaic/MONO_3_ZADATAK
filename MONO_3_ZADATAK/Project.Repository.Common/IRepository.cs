using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Common
{
    public interface IRepository
    {
        Task<T> Get<T>(Guid id) where T : class;
        Task<IEnumerable<T>> GetAll<T>() where T : class;
        Task<int> Add<T>(T entity) where T : class;
        Task<int> Update<T>(T entity) where T : class;
        Task<int> Delete<T>(Guid id) where T : class;
    }
}
