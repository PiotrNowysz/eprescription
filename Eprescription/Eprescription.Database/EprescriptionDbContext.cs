using Microsoft.EntityFrameworkCore;

namespace Eprescription.Database
{
    public class EprescriptionDbContext : DbContext
    {
        public EprescriptionDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicinePrescription>().HasKey(sc => new { sc.MedicineId, sc.PrescriptionId });
        }
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Medicine> Medicines { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<MedicinePrescription> MedicinePrescriptions { get; set; }
    }
}
