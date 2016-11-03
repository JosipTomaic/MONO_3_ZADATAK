using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Repository.Common;
using Project.DAL;
using Project.DAL.Common;
using System.Data.Entity;

namespace Project.Repository
{
    public class Repository : IRepository
    {
        private IVehicleContext Context { get; set; }
        private IUnitOfWork UnitOfWork { get; set; }

        public Repository(IVehicleContext context, IUnitOfWork unitofwork)
        {
            Context = context;
            UnitOfWork = unitofwork;
        }
        public async Task<int> Add<T>(T entity) where T : class
        {
            Context.Set<T>().Add(entity);
            return await UnitOfWork.Save();
        }

        public async Task<int> Delete<T>(Guid id) where T : class
        {
            T entity = await Get<T>(id);
            Context.Set<T>().Remove(entity);
            return await UnitOfWork.Save();
        }

        public async Task<T> Get<T>(Guid id) where T : class
        {
            return await Context.Set<T>().FindAsync(id);
        }

        public async Task<int> Update<T>(T entity) where T : class
        {
            Context.Entry(entity).State = EntityState.Modified;
            return await UnitOfWork.Save();
        }

        public async Task<IEnumerable<T>> GetAll<T>() where T : class
        {
            return await Context.Set<T>().ToListAsync();
        }
    }
}
