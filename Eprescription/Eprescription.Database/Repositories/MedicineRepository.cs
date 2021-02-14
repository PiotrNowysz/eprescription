using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Eprescription.Database
{
    public class MedicineRepository : BaseRepository<Medicine>, IMedicineRepository
    {
        protected override DbSet<Medicine> DbSet => _dbContext.Medicines;

        public MedicineRepository(EprescriptionDbContext dbContext) : base(dbContext)
        {
        }

    }
}
