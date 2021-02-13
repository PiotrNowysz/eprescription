using System.Collections.Generic;

namespace Eprescription
{
    public class DoctorsViewModel
    {
        public string Name { get; set; }
        public List<PrescriptionViewModel> Prescriptions { get; set; }
    }
}
