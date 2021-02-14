using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Eprescription.Database
{
    public class PrescriptionRepository : BaseRepository<Prescription>, IPrescriptionRepository
    {
        protected override DbSet<Prescription> DbSet => _dbContext.Prescriptions;

        public PrescriptionRepository(EprescriptionDbContext dbContext) : base(dbContext)
        {
        }

    }
}
