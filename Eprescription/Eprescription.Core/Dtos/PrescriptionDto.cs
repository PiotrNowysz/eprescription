using System;
using System.Collections.Generic;

namespace Eprescription.Core
{
    public class PrescriptionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Pesel { get; set; }
        public int ActivationCode { get; set; }
        public string PatientEmail { get; set; }
        public IList<MedicinePrescriptionDto> MedicinePrescriptions { get; set; }
        public DoctorDto Doctor { get; set; }
    }
}
