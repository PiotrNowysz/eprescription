using System;
using System.Collections.Generic;
using System.Text;

namespace Eprescription.Core
{
    public interface IMedicineManager : IBaseManager<MedicineDto>
    {
        IEnumerable<MedicineDto> GetAllMedicines(string filterString = null);
    }
}
