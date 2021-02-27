using System.Collections.Generic;

namespace Eprescription.Database
{
    public interface IBaseRepository<Entity> where Entity : BaseEntity
    {
        public IEnumerable<Entity> GetAll();
        public bool AddNew(Entity entity);
        public bool Delete(Entity entity);
        public bool SaveChanges();
    }
}
