using Microsoft.EntityFrameworkCore;

namespace Eprescription.Database
{
    public class EprescriptionDbContext : DbContext
    {
        public EprescriptionDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
