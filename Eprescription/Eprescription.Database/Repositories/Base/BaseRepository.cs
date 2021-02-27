using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Eprescription.Database
{
    public abstract class BaseRepository<Entity> where Entity : BaseEntity
    {
        protected EprescriptionDbContext _dbContext;
        protected abstract DbSet<Entity> DbSet { get; }

        public BaseRepository(EprescriptionDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual IEnumerable<Entity> GetAll()
        {
            return DbSet.Select(x => x);
        }

        public bool AddNew(Entity entity)
        {
            DbSet.Add(entity);

            return SaveChanges();
        }

        public bool Delete(Entity entity)
        {
            var entityToRemove = DbSet.FirstOrDefault(x => x.Id == entity.Id);
            if (entityToRemove != null)
            {
                DbSet.Remove(entityToRemove);
                return SaveChanges();
            }
            return false;
        }

        public bool SaveChanges()
        {
            return _dbContext.SaveChanges() > 0;
        }
    }
}

