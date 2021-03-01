using System.Collections.Generic;

namespace Eprescription
{
    public class MedicineViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProducentName { get; set; }
        public string Composition { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public decimal TotalPrice { get; set; }
        public IList<MedicinePrescriptionViewModel> MedicinePrescriptions { get; set; }
    }
}
