using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Repository.Common;
using Project.DAL.Common;

namespace Project.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private IVehicleContext Context;

        public UnitOfWork(IVehicleContext context)
        {
            Context = context;
        }
        public void Dispose()
        {
            Context.Dispose();
        }

        public Task<int> Save()
        {
           return Context.SaveChangesAsync();
        }
    }
}
