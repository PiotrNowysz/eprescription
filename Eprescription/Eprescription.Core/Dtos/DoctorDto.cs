using System.Collections.Generic;

namespace Eprescription.Core
{
    public class DoctorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public List<PrescriptionDto> Prescriptions { get; set; }
    }
}
