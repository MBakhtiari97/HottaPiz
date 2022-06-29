using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Context;
using HottaPiz.DataLayer.Entities.Common;

namespace HottaPiz.DataLayer.Repositories.Interfaces
{
    public interface IGenericRepository <TEntity> where TEntity : BaseEntity
    {

        public IQueryable<TEntity> GetAll();
        public Task<TEntity> GetEntityByIdAsync(int id);
        public Task<bool> CreateEntityAsync(TEntity entity);
        public bool UpdateEntity(TEntity entity);
        public bool RemoveEntity(TEntity entity);
        public Task<bool> RemoveEntityAsync(int id);
        public Task SaveChangesAsync();
    }
}
