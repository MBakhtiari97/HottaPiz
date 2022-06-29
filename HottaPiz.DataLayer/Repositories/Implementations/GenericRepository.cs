using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Context;
using HottaPiz.DataLayer.Entities.Common;
using HottaPiz.DataLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HottaPiz.DataLayer.Repositories.Implementations
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        #region Constructor

        private readonly HottaPizContext _context;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(HottaPizContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        #endregion

        #region Get Entity

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public async Task<TEntity> GetEntityByIdAsync(int id)
        {
            return await _dbSet.SingleAsync(e => e.Id == id);
        }

        #endregion

        #region Create Entity

        public async Task<bool> CreateEntityAsync(TEntity entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Update Entity

        public bool UpdateEntity(TEntity entity)
        {
            try
            {
                _dbSet.Update(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Remove Entity

        public bool RemoveEntity(TEntity entity)
        {
            try
            {
                entity.IsDelete = true;
                _dbSet.Update(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> RemoveEntityAsync(int id)
        {
            try
            {
                var entity = await GetEntityByIdAsync(id);

                if (entity != null)
                {
                    RemoveEntity(entity);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Save Changes

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        #endregion
    }
}
