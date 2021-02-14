using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Eprescription
{
    public class Prescription
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Pesel { get; set; }
        public int ActivationCode { get; set; }
        public string PatientEmail { get; set; }
        public IList<MedicinePrescription> MedicinePrescriptions { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
