using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Eprescription.Database
{
    abstract public class BaseRepository<Entity> where Entity : class
    {
        protected EprescriptionDbContext _dbContext;
        protected abstract DbSet<Entity> DbSet { get;}
        public BaseRepository(EprescriptionDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Entity> GetAll()
        {
            var entitiesList = new List<Entity>();
            foreach (var entity in DbSet) entitiesList.Add(entity);
            return entitiesList;
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}

