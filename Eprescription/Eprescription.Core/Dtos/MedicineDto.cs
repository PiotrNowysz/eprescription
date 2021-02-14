using System.Collections.Generic;

namespace Eprescription.Core
{
    public class MedicineDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProducentName { get; set; }
        public string Composition { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public decimal TotalPrice { get; set; }
        public IList<MedicinePrescriptionDto> MedicinePrescriptions { get; set; }
    }
}
