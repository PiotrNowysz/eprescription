using System.Collections.Generic;

namespace Eprescription.Database
{
    public class Medicine : BaseEntity
    {
        public string Name { get; set; }
        public string ProducentName { get; set; }
        public string Composition { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public IList<MedicinePrescription> MedicinePrescriptions { get; set; }
    }
}
