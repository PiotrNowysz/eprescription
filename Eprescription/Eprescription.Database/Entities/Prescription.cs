using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eprescription.Database
{
    public class Prescription : BaseEntity
    {
        public string Name { get; set; }
        public DateTime CreatingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Pesel { get; set; }
        public int ActivationCode { get; set; }
        public string PatientEmail { get; set; }
        public IList<MedicinePrescription> MedicinePrescriptions { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        [Required]
        public virtual Doctor Doctor { get; set; }
    }
}
