using Microsoft.EntityFrameworkCore;

namespace Eprescription.Database
{
    public class MedicineRepository : BaseRepository<Medicine>, IDoctorRepository
    {
        protected override DbSet<Medicine> DbSet => _dbContext.Medicines;

        public MedicineRepository(EprescriptionDbContext dbContext) : base(dbContext)
        {
        }
    }
}
