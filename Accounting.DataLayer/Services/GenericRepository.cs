using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private Accounting_DBEntities _dBEntities;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(Accounting_DBEntities Context)
        {
            _dBEntities = Context;
            _dbSet = _dBEntities.Set<TEntity>();
        }

        public virtual TEntity GetById(object Id)
        {
            return _dbSet.Find(Id);
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> condition = null)
        {
            //return _dbSet.ToList();
            IQueryable<TEntity> query = _dbSet;
            if (condition != null)
            {
                query = query.Where(condition);
            }

            return query.ToList();
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _dBEntities.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            if (_dBEntities.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public virtual void Delete(object Id)
        {
            TEntity mentity = GetById(Id);
            Delete(mentity);
        }

        /*public class TextGenericRepository()
        {
            GenericRepository<Customers> customer = new GenericRepository<Customers>(); 
        }*/
    }

}
