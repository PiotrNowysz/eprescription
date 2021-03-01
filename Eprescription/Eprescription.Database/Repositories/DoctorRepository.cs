using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Eprescription.Database
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        protected override DbSet<Doctor> DbSet => _dbContext.Doctors;

        public DoctorRepository(EprescriptionDbContext dbContext) : base(dbContext)
        {
        }
        public override IEnumerable<Doctor> GetAll()
        {
            return DbSet/*.Include(x=> x.Prescriptions)*/.Select(x => x);
        }
    }
}
