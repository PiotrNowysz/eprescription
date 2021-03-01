using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eprescription
{
    public class PrescriptionViewModel
    {
        public List<MedicineViewModel> Medicines { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Pesel { get; set; }
        public int ActivationCode { get; set; }
        public string PatientEmail { get; set; }
        public IList<MedicinePrescriptionViewModel> MedicinePrescriptions { get; set; }
        [Required]
        public DoctorViewModel Doctor { get; set; }
    }
}
