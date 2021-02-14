using Microsoft.EntityFrameworkCore;

namespace Eprescription.Database
{
    public class PrescriptionRepository : BaseRepository<Prescription>, IDoctorRepository
    {
        protected override DbSet<Prescription> DbSet => _dbContext.Prescriptions;

        public PrescriptionRepository(EprescriptionDbContext dbContext) : base(dbContext)
        {
        }
    }
}
