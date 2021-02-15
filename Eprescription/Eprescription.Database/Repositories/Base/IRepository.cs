using System.Collections.Generic;

namespace Eprescription.Database
{
    public interface IRepository<Entity> where Entity : BaseEntity
    {
        public IEnumerable<Entity> GetAll();
        public bool AddNew(Entity entity);
        public bool Delete(Entity entity);
        public bool SaveChanges();
    }
}
