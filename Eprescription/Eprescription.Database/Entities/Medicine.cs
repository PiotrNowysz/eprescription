using System.Collections.Generic;

namespace Eprescription
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProducentName { get; set; }
        public string Composition { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public IList<MedicinePrescription> MedicinePrescriptions { get; set; }
    }
}
