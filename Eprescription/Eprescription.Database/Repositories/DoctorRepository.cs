using Microsoft.EntityFrameworkCore;

namespace Eprescription.Database
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        protected override DbSet<Doctor> DbSet => _dbContext.Doctors;

        public DoctorRepository(EprescriptionDbContext dbContext) : base(dbContext)
        {
        }
    }
}
